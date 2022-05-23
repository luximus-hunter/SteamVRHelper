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
            LblBackup.Text = _l.GetString("BackupFiles");
            BtnBackup.Content = _l.GetString("Backup");
            LblRestore.Text = _l.GetString("RestoreFiles");
            BtnRestore.Content = _l.GetString("Restore");
        }

        private void BtnBackupClick(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            Scripts.Upscaler _u = new();
            _u.Backup();

            Scripts.NoOculus _no = new();
            _no.Backup();
        }

        private void BtnRestoreClick(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            Scripts.Upscaler _u = new();
            _u.Restore();

            Scripts.NoOculus _no = new();
            _no.Restore();
        }
    }
}
