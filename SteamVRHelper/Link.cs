using System.Diagnostics;

namespace SteamVRHelper
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
