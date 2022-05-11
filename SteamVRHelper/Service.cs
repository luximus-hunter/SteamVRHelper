using System.Diagnostics;

namespace SteamVRHelper
{
    internal enum VRService
    {
        SteamVR = 0,
        Oculus = 1
    }

    internal class Service
    {
        private VRService activeService;

        private bool inited;

        public Service()
        {
            if(File.Exists(Locations.OculusFile) && !File.Exists(Locations.OculusBackupFile))
            {
                File.Copy(Locations.OculusFile, Locations.OculusBackupFile);
            }

            if (File.Exists(Locations.OculusBackupFile) && File.Exists(Locations.OculusKillerFile))
            {
                inited = true;
            }

            if(inited)
            {
                if (File.ReadAllBytes(Locations.OculusFile).Length == File.ReadAllBytes(Locations.OculusKillerFile).Length)
                {
                    activeService = VRService.SteamVR;
                }
                else
                {
                    activeService = VRService.Oculus;
                }
            }
        }

        public void ActivateSteamVR()
        {
            if (File.ReadAllBytes(Locations.OculusFile).Length != File.ReadAllBytes(Locations.OculusKillerFile).Length)
            {
                File.Copy(Locations.OculusKillerFile, Locations.OculusFile, true);
                activeService = VRService.SteamVR;
            }
        }

        public void ActivateOculus()
        {
            if (File.ReadAllBytes(Locations.OculusFile).Length != File.ReadAllBytes(Locations.OculusBackupFile).Length)
            {
                File.Copy(Locations.OculusBackupFile, Locations.OculusFile, true);
                activeService = VRService.Oculus;
            }
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

        public bool Inited
        {
            get => inited;
            set => inited = value;
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
