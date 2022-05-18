using System.Security.Principal;

namespace SteamVRHelper
{
    public partial class Window : Form
    {
        private NoOculus noOculus = new();
        private Upscaler upscaler = new();
        private Library library = new();

        public Window()
        {
            InitializeComponent();

            #region Service

            if (!IsAdministrator())
            {
                gbxService.Text += " - Run as administrator";
                gbxService.Enabled = false;
            }

            if (!noOculus.DetectOculus())
            {
                gbxService.Enabled = false;
            }

            UpdateServiceLabel();

            #endregion

            #region OpenVR

            if (upscaler.Algorithm == UpscaleAlgorithm.FSR)
            {
                rbtnFSR.Checked = true;
            }
            else
            {
                rbtnNIS.Checked = true;
            }

            tbrRenderScale.Value = upscaler.RenderScale;
            tbrSharpness.Value = upscaler.Sharpness;

            lblRenderScaleValue.Text = ((double)tbrRenderScale.Value / 100).ToString();
            lblSharpnessValue.Text = ((double)tbrSharpness.Value / 100).ToString();

            foreach (Game game in library.Games)
            {
                lbxUpscaledGames.Items.Add(game.Name);
            }
            
            #endregion
        }

        private void UpdateServiceLabel()
        {
            if (noOculus.ActiveService == VRService.Steam)
            {
                lblActiveService.Text = "Active service: Steam";
            }
            else if (noOculus.ActiveService == VRService.Oculus)
            {
                lblActiveService.Text = "Active service: Oculus";
            }
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            NoOculus.Exit();
        }

        private void rbtnOpenVR_Changed(object sender, EventArgs e)
        {
            if (rbtnFSR.Checked && upscaler.Algorithm != UpscaleAlgorithm.FSR)
            {
                upscaler.Algorithm = UpscaleAlgorithm.FSR;
            }
            else if (rbtnNIS.Checked && upscaler.Algorithm != UpscaleAlgorithm.NIS)
            {
                upscaler.Algorithm = UpscaleAlgorithm.NIS;
            }
        }

        private void tbrRenderScale_Scroll(object sender, EventArgs e)
        {
            int value = tbrRenderScale.Value;
            lblRenderScaleValue.Text = ((double)value / 100).ToString();
            upscaler.RenderScale = value;
        }

        private void tbrSharpness_Scroll(object sender, EventArgs e)
        {
            int value = tbrSharpness.Value;
            lblSharpnessValue.Text = ((double)value / 100).ToString();
            upscaler.Sharpness = value;
        }

        private void btnApplyUpscaling_Click(object sender, EventArgs e)
        {
            upscaler.Apply();
        }

        private void btnEnableUpscaling_Click(object sender, EventArgs e)
        {
            upscaler.Enable();
        }

        private void btnDisableUpscaling_Click(object sender, EventArgs e)
        {
            upscaler.Disable();
        }

        private void btnBackupService_Click(object sender, EventArgs e)
        {
            noOculus.Backup();
        }

        private void btnServiceSteam_Click(object sender, EventArgs e)
        {
            noOculus.Enable();
            UpdateServiceLabel();
        }

        private void btnServiceOculus_Click(object sender, EventArgs e)
        {
            noOculus.Disable();
            UpdateServiceLabel();
        }

        private void btnUpscalerBackup_Click(object sender, EventArgs e)
        {
            upscaler.Backup();
        }
    }
}