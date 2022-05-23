using System.Diagnostics;
using System.IO;

namespace SteamVRHelperV2.Scripts
{
    internal enum VRService
    {
        Steam = 0,
        Oculus = 1
    }

    internal enum NoOculusToggleArg
    {
        Backup = 0,
        Enable = 1,
        Disable = 2,
        Restore = 3
    }

    internal class NoOculus
    {
        private VRService _as;

        public NoOculus()
        {
            string backupFile = Locations.OculusFile + Locations.BackupExtension;

            if (!BackedUp()) 
            {
                Backup();
            }

            if (DetectOculus() && DetectKiller())
            {
                if (File.ReadAllBytes(Locations.OculusFile).Length == File.ReadAllBytes(Locations.OculusKillerFile).Length)
                {
                    _as = VRService.Steam;
                }
                else
                {
                    _as = VRService.Oculus;
                }
            }
        }

        public static bool BackedUp()
        {
            return File.Exists(Locations.OculusBackupFile);
        }

        public static bool DetectOculus()
        {
            return File.Exists(Locations.OculusFile);
        }

        public static bool DetectKiller()
        {
            return File.Exists(Locations.OculusKillerFile);
        }

        public void Backup()
        {
            Execute(NoOculusToggleArg.Backup);
        }

        public void Enable()
        {
            Execute(NoOculusToggleArg.Enable);
            _as = VRService.Steam;
        }

        public void Disable()
        {
            Execute(NoOculusToggleArg.Disable);
            _as = VRService.Oculus;
        }

        public void Restore()
        {
            Execute(NoOculusToggleArg.Restore);
        }

        public static void Exit()
        {
            KillProgram("OculusClient");
            KillProgram("vrmonitor");
        }

        public void Execute(NoOculusToggleArg arg)
        {
            if (!File.Exists(Locations.NoOculusToggle))
            {
                return;
            }

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = @".";
            startInfo.FileName = Locations.NoOculusToggle;
            startInfo.Verb = "runas";

            switch (arg)
            {
                case NoOculusToggleArg.Backup:
                    startInfo.Arguments = "-b";
                    break;
                case NoOculusToggleArg.Enable:
                    startInfo.Arguments = "-e";
                    break;
                case NoOculusToggleArg.Disable:
                    startInfo.Arguments = "-d";
                    break;
                case NoOculusToggleArg.Restore:
                    startInfo.Arguments = "-r";
                    break;
            }

            process.StartInfo = startInfo;

            try
            {
                process.Start();
            }
            catch (System.Exception)
            {
                // no admin?
            }
        } 

        #region Getters and Setters

        public VRService ActiveService
        {
            get => _as;
            set => _as = value;
        }

        #endregion

        #region KillProgram

        public static void KillProgram(string name)
        {
            Process[]? processes = null;

            try
            {
                processes = Process.GetProcessesByName(name);

                if (processes.Length < 1)
                {
                    return;
                }

                Process process = processes[0];

                if (!process.HasExited)
                {
                    process.Kill();
                }
            }
            finally
            {
                if (processes != null)
                {
                    foreach (Process process in processes)
                    {
                        process.Dispose();
                    }
                }
            }
        }

        #endregion
    }
}
