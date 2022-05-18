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
        static void Main(string[] args)
        {
            if (args.Contains("--exit"))
            {
                NoOculus.Exit();
            }
            else
            {
                Locations.CreateDirectory(Locations.Root);
                Locations.CreateDirectory(Locations.TemplateDirectory);

                ApplicationConfiguration.Initialize();
                Application.Run(new Window());
            }
        }
    }
}