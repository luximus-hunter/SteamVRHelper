using System.Diagnostics;

namespace SteamVRHelperV2.Scripts
{
    internal static class Link
    {
        public static void Open(string link)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            });
        }
    }
}
