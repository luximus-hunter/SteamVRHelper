using System.Diagnostics;


namespace SteamVRHelper
{
    public partial class Window : Form
    {
        private string oculesPath = @"C:\Program Files\Oculus\Support\oculus-dash\dash\bin\";
        private string oculesFile = "OculusDash.exe";
        private string backupExtension = ".bak";
        private string tempExtension = ".temp";

        private string activeFilePath;
        private string backupFilePath;
        private string tempFilePath;

        private bool hasOculusKiller;
        private int service;
            // 0 = SteamVR
            // 1 = Oculus

        public Window()
        {
            InitializeComponent();

            btnGetSteamVR.Visible = false;

            activeFilePath = oculesPath + oculesFile;
            backupFilePath = oculesPath + oculesFile + backupExtension;
            tempFilePath   = oculesPath + oculesFile + tempExtension;

            if(File.Exists(backupFilePath))
            {
                hasOculusKiller = true;

                int activeFileSize = File.ReadAllBytes(activeFilePath).Length;
                int backupFileSize = File.ReadAllBytes(backupFilePath).Length;

                if (activeFileSize > backupFileSize)
                {
                    service = 1;
                    rbtnOculus.Checked = true;
                }
                else
                {
                    service = 0;
                    rbtnSteamVR.Checked = true;
                }
            } 
            else
            {
                hasOculusKiller = false;
                rbtnSteamVR.Enabled = false;
                rbtnOculus.Checked = true;
                btnGetSteamVR.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitVR();
        }

        public void ExitVR()
        {
            KillProgram("OculusClient");
            KillProgram("vrmonitor");
        }

        private void rbtnService_Changed(object sender, EventArgs e)
        {
            if(hasOculusKiller)
            {
                if (rbtnOculus.Checked && service != 1)
                {
                    SwapFiles();
                }
                else if (rbtnSteamVR.Checked && service != 0)
                {
                    SwapFiles();
                }
            }
        }

        public void SwapFiles()
        {
            try
            {
                File.Move(activeFilePath, tempFilePath);
                File.Move(backupFilePath, activeFilePath);
                File.Move(tempFilePath, backupFilePath);

                int activeFileSize = File.ReadAllBytes(activeFilePath).Length;
                int backupFileSize = File.ReadAllBytes(backupFilePath).Length;

                if (activeFileSize > backupFileSize)
                {
                    service = 1;
                }
                else
                {
                    service = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't change service.\nPlease run as administrator.");
            }
        }

        public void KillProgram(string name)
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

        private void btnGetSteamVR_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/ItsKaitlyn03/OculusKiller",
                UseShellExecute = true
            });
        }
    }
}