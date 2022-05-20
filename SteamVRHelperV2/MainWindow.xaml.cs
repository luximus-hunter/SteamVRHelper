using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using SteamVRHelperV2.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SteamVRHelperV2
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private Scripts.Language _l = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region NavigationView event handlers
        private void MenuContainerLoaded(object sender, RoutedEventArgs e)
        {
            // set the initial SelectedItem
            foreach (NavigationViewItemBase item in menuContainer.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "menuItemUpscaling")
                {
                    menuContainer.SelectedItem = item;
                    break;
                }
            }

            contentFrame.Navigate(typeof(Upscaling));
            menuContainer.Header = _l.GetRawString("Upscaling.Title");

            NavUpscaling.Text = _l.GetRawString("Upscaling.Title");
            NavNoOculus.Text = _l.GetRawString("NoOculus.Title");
            NavExit.Text = _l.GetRawString("Exit.Title");
        }

        private void MenuContainerSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
        }

        private void MenuContainerItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                contentFrame.Navigate(typeof(Settings));
                menuContainer.Header = args.InvokedItem;
            }
            else
            {
                TextBlock itemContent = args.InvokedItem as TextBlock;

                if (itemContent != null)
                {
                    switch (itemContent.Tag)
                    {
                        case "navUpscaling":
                            contentFrame.Navigate(typeof(Upscaling));
                            menuContainer.Header = itemContent.Text;
                            break;
                        case "navNoOculus":
                            contentFrame.Navigate(typeof(NoOculus));
                            menuContainer.Header = itemContent.Text;
                            break;
                        case "navExit":
                            contentFrame.Navigate(typeof(Exit));
                            menuContainer.Header = itemContent.Text;
                            break;
                    }
                }
            }
        }
        #endregion
    }
}
