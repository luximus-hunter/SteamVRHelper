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
        private Scripts.Library _lib = new();

        public List<string> Algorithms;

        public Upscaling()
        {
            InitializeComponent();

            Algorithms = new()
            {
                _l.GetString("FSR"),
                _l.GetString("NIS")
            };

            #region Labels

            ChbxEnableUpscaling.Content = _l.GetString("Enable");
            LblAlgirithm.Text = _l.GetString("Algorithm");
            LblScale.Text = _l.GetString("Scale");
            LblSharpness.Text = _l.GetString("Sharpness");
            BtnApply.Content = _l.GetRawString("Settings.Apply");

            #endregion
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
            _u.Enable();
            CbxAlgorithm.IsEnabled = true;
            SldScale.IsEnabled = true;
            SldSharpness.IsEnabled = true;
            BtnApply.IsEnabled = true;
        }

        private void ChbxEnableUpscalingUnchecked(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            _u.Disable();
            CbxAlgorithm.IsEnabled = false;
            SldScale.IsEnabled = false;
            SldSharpness.IsEnabled = false;
            BtnApply.IsEnabled = false;
        }

        private void SldScaleChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            _u.RenderScale = (int)SldScale.Value;
        }

        private void SldSharpnessChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            _u.Sharpness = (int)SldSharpness.Value;
        }

        private void BtnApplyClick(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            _u.Apply();
        }

        private void SldScaleLoaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            SldScale.Value = _u.RenderScale;
        }

        private void SldSharpnessLoaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            SldSharpness.Value = _u.Sharpness;
        }

        private void ChbxEnableUpscalingLoaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            ChbxEnableUpscaling.IsChecked = _u.Enabled();

            if ((bool)ChbxEnableUpscaling.IsChecked) 
            {
                CbxAlgorithm.IsEnabled = true;
                SldScale.IsEnabled = true;
                SldSharpness.IsEnabled = true;
                BtnApply.IsEnabled = true;
            }
            else
            {
                CbxAlgorithm.IsEnabled = false;
                SldScale.IsEnabled = false;
                SldSharpness.IsEnabled = false;
                BtnApply.IsEnabled = false;
            }
        }

        private void CbxAlgorithmChanged(object sender, SelectionChangedEventArgs e)
        {
            string algorithm = e.AddedItems[0].ToString();

            if (algorithm == _l.GetString("FSR"))
            {
                _u.Algorithm = Scripts.UpscaleAlgorithm.FSR;
            }
            else if (algorithm == _l.GetString("NIS"))
            {
                _u.Algorithm = Scripts.UpscaleAlgorithm.NIS;
            }
        }
    }
}
