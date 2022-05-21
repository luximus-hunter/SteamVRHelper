using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SteamVRHelperV2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Settings : Page
    {
        private Scripts.Language _l = new("Settings");

        public Settings()
        {
            InitializeComponent();

            LblAuthor.Text = _l.GetString("Author");
            LblAuthorName.Text = _l.GetString("AuthorName");
            LblVersion.Text = _l.GetString("Version");
            LblVersionNumber.Text = _l.GetString("VersionNumber");
            ChbxExperimentalWarning.Content = _l.GetString("DisableExperimentalWarning");
            LblRestore.Text = _l.GetString("RestoreFiles");
            BtnRestore.Content = _l.GetString("Restore");

            ChbxExperimentalWarning.IsEnabled = false;
            BtnRestore.IsEnabled = false;
        }
    }
}
