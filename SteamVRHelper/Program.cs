using System.Diagnostics;
using System.Security.Principal;

namespace SteamVRHelper
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Window());
       }
    }
}