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
        Disable = 2
    }

    internal class NoOculus
    {
        private VRService activeService;

        public NoOculus()
        {
            string backupFile = Locations.OculusFile + Locations.BackupExtension;

            if (!File.Exists(backupFile)) 
            {
                Backup();
            }

            if (DetectOculus() && DetectKiller())
            {
                if (File.ReadAllBytes(Locations.OculusFile).Length == File.ReadAllBytes(Locations.OculusKillerFile).Length)
                {
                    activeService = VRService.Steam;
                }
                else
                {
                    activeService = VRService.Oculus;
                }
            }
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
            activeService = VRService.Steam;
        }

        public void Disable()
        {
            Execute(NoOculusToggleArg.Disable);
            activeService = VRService.Oculus;
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
            }

            process.StartInfo = startInfo;
            process.Start();
        } 

        #region Getters and Setters

        public VRService ActiveService
        {
            get => activeService;
            set => activeService = value;
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
