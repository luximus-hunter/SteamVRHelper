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
                Service.Exit();
            }
            else
            {
                Locations.CreateDirectory(Locations.BackupDirectory);
                Locations.CreateDirectory(Locations.GamesBackupDirectory);
                Locations.CreateDirectory(Locations.OculusBackupDirectory);
                Locations.CreateDirectory(Locations.TemplateDirectory);

                ApplicationConfiguration.Initialize();
                Application.Run(new Window());
            }
        }
    }
}