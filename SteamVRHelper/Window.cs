using System.Security.Principal;

namespace SteamVRHelper
{
    public partial class Window : Form
    {
        private Service service = new();
        private OpenVR openVR = new();
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

            btnGetSteamVR.Visible = false;

            if (!File.Exists(Locations.OculusFile))
            {
                gbxService.Enabled = false;
                rbtnSteamVR.Checked = true;
            }
            else
            {
                if (service.Inited)
                {
                    if (service.ActiveService == VRService.SteamVR)
                    {
                        rbtnSteamVR.Checked = true;
                    }
                    else
                    {
                        rbtnOculus.Checked = true;
                    }
                }
                else
                {
                    rbtnSteamVR.Enabled = false;
                    rbtnOculus.Checked = true;
                    btnGetSteamVR.Visible = true;
                }
            }

            #endregion

            #region OpenVR

            if (!openVR.Inited)
            {
                btnGetUpscaling.Visible = true;
                chbxEnableUpscaling.Enabled = false;
                gbxUpscaling.Enabled = false;
            } 
            else
            {
                if (openVR.Upscaler == OpenVRUpscaler.FSR)
                {
                    rbtnFSR.Checked = true;
                }
                else
                {
                    rbtnNIS.Checked = true;
                }

                tbrRenderScale.Value = openVR.RenderScale;
                tbrSharpness.Value = openVR.Sharpness;

                btnGetUpscaling.Visible = false;
                //chlbxUpscaledGames.Enabled = false;

                lblRenderScaleValue.Text = ((double)tbrRenderScale.Value / 100).ToString();
                lblSharpnessValue.Text = ((double)tbrSharpness.Value / 100).ToString();

                if (Directory.GetDirectories(Locations.GamesBackupDirectory).Length > 0)
                {
                    chbxEnableUpscaling.Checked = true;
                }

                if (!chbxEnableUpscaling.Checked)
                {
                    gbxUpscaling.Enabled = false;
                }

                foreach (Game game in library.Games)
                {
                    lbxUpscaledGames.Items.Add(game.Name);
                }
            }

            #endregion
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Service.Exit();
        }

        private void rbtnService_Changed(object sender, EventArgs e)
        {
            if(service.Inited)
            {
                if (rbtnSteamVR.Checked)
                {
                    service.ActivateSteamVR();
                }
                else if (rbtnOculus.Checked)
                {
                    service.ActivateOculus();
                }
            }
        }

        private void rbtnOpenVR_Changed(object sender, EventArgs e)
        {
            if (rbtnFSR.Checked && openVR.Upscaler != OpenVRUpscaler.FSR)
            {
                openVR.Upscaler = OpenVRUpscaler.FSR;
            }
            else if (rbtnNIS.Checked && openVR.Upscaler != OpenVRUpscaler.NIS)
            {
                openVR.Upscaler = OpenVRUpscaler.NIS;
            }
        }

        private void chbxEnableUpscaling_CheckedChanged(object sender, EventArgs e)
        {
            gbxUpscaling.Enabled = chbxEnableUpscaling.Checked;

            if(chbxEnableUpscaling.Checked)
            {
                openVR.Backup();
            }
            else
            {
                openVR.Restore();
            }
        }

        private void tbrRenderScale_Scroll(object sender, EventArgs e)
        {
            int value = tbrRenderScale.Value;
            lblRenderScaleValue.Text = ((double)value / 100).ToString();
            openVR.RenderScale = value;
        }

        private void tbrSharpness_Scroll(object sender, EventArgs e)
        {
            int value = tbrSharpness.Value;
            lblSharpnessValue.Text = ((double)value / 100).ToString();
            openVR.Sharpness = value;
        }

        private void btnApplyUpscaling_Click(object sender, EventArgs e)
        {
            openVR.Save();
        }

        private void btnGetSteamVR_Click(object sender, EventArgs e)
        {
            Link.Open("https://github.com/ItsKaitlyn03/OculusKiller/releases/latest");
        }

        private void btnGetUpscaling_Click(object sender, EventArgs e)
        {
            Link.Open("https://github.com/fholger/openvr_fsr/releases/latest");
        }
    }
}