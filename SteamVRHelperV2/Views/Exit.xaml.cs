using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SteamVRHelperV2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Exit : Page
    {
        private Scripts.Language _l = new("Exit");

        public Exit()
        {
            InitializeComponent();

            LblExitVR.Text = _l.GetString("ExitVR");
            BtnExitVR.Content = _l.GetString("Button");
        }

        private void BtnExitVRClick(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            Scripts.NoOculus.Exit();
        }
    }
}
