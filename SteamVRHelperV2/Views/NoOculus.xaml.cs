using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using SteamVRHelperV2.Scripts;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SteamVRHelperV2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NoOculus : Page
    {
        private Scripts.NoOculus _no = new();
        private Scripts.Language _l = new("NoOculus");

        public List<string> Services;

        public NoOculus()
        {
            this.InitializeComponent();

            Services = new()
            {
                _l.GetString("Steam"),
                _l.GetString("Oculus")
            };

            if (Scripts.NoOculus.DetectOculus())
            {
                MsgNoOculusBar.Visibility = Microsoft.UI.Xaml.Visibility.Collapsed;
            }

            #region Language

            LblService.Text = _l.GetString("Service");
            MsgNoOculusBar.Title = _l.GetString("NotDetectedTitle");
            MsgNoOculusBar.Message = _l.GetString("NotDetected");
            BtnApply.Content = _l.GetRawString("Settings.Apply");
            ChbxFixExit.Content = _l.GetString("FixExit");

            #endregion

        }

        private void CbxServicesLoaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            switch (_no.ActiveService)
            {
                case VRService.Steam:
                    CbxServices.SelectedValue = _l.GetString("Steam");
                    break;
                case VRService.Oculus:
                    CbxServices.SelectedValue = _l.GetString("Oculus");
                    break;
            }
        }

        private void CbxServicesChanged(object sender, SelectionChangedEventArgs e)
        {
            string service = e.AddedItems[0].ToString();

            if (service == _l.GetString("Steam"))
            {
                _no.ActiveService = VRService.Steam;
            }
            else if (service == _l.GetString("Oculus"))
            {
                _no.ActiveService = VRService.Oculus;
            }
        }

        private void BtnApplyClick(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            string service = CbxServices.SelectedValue.ToString();

            if (service == _l.GetString("Steam"))
            {
                _no.Enable();
            }
            else if (service == _l.GetString("Oculus"))
            {
                _no.Disable();
            }
        }

        private void ChbxFixExitChecked(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void ChbxFixExitUnchecked(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
