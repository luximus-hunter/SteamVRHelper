using System.Diagnostics;

namespace SteamVRHelper
{
    internal enum VRService
    {
        Steam = 0,
        Oculus = 1
    }

    internal class NoOculus
    {
        private VRService activeService;

        public NoOculus()
        {
            Backup();

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

        public bool DetectOculus()
        {
            return File.Exists(Locations.OculusFile);
        }

        public bool DetectKiller()
        {
            return File.Exists(Locations.OculusKillerFile);
        }

        public void Backup()
        {
            string activeFile = Locations.OculusFile;
            string backupFile = Locations.OculusFile + Locations.BackupExtension;

            if (!File.Exists(backupFile))
            {
                File.Copy(activeFile, backupFile, true);
            }
        }

        public void Enable()
        {
            File.Copy(Locations.OculusKillerFile, Locations.OculusFile, true);
            activeService = VRService.Steam;
        }

        public void Disable()
        {
            File.Copy(Locations.OculusBackupFile, Locations.OculusFile, true);
            activeService = VRService.Oculus;
        }

        public static void Exit()
        {
            KillProgram("OculusClient");
            KillProgram("vrmonitor");
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
