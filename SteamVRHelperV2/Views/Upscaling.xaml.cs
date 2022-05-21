using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SteamVRHelperV2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Upscaling : Page
    {
        private Scripts.Language _l = new("Upscaling");
        private Scripts.Upscaler _u = new();

        public List<string> Algorithms;

        public Upscaling()
        {
            InitializeComponent();

            Algorithms = new()
            {
                _l.GetString("FSR"),
                _l.GetString("NIS")
            };

            ChbxEnableUpscaling.Content = _l.GetString("Enable");
            LblAlgirithm.Text = _l.GetString("Algorithm");
            LblScale.Text = _l.GetString("Scale");
            LblSharpness.Text = _l.GetString("Sharpness");
            BtnApply.Content = _l.GetRawString("Settings.Apply");


            ExpScaledGames.Header = _l.GetString("ScaledGames");
        }

        private void CbxAlgorithmLoaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            switch (_u.Algorithm)
            {
                case Scripts.UpscaleAlgorithm.FSR:
                    CbxAlgorithm.SelectedValue = _l.GetString("FSR");
                    break;
                case Scripts.UpscaleAlgorithm.NIS:
                    CbxAlgorithm.SelectedValue = _l.GetString("NIS");
                    break;
            }
        }

        private void ChbxEnableUpscalingChecked(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void ChbxEnableUpscalingUnchecked(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void SldScaleChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {

        }

        private void SldSharpnessChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {

        }

        private void BtnApplyClick(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
