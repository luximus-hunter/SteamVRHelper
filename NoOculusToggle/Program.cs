namespace NoOculusToggle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("No argument provided");
            }
            else if(args.Length > 1)
            {
                Console.WriteLine("Too many arguments provided");
            }
            else
            {
                switch(args[0])
                {
                    case "-b":
                        Backup();
                        break;
                    case "-e":
                        Enable();
                        break;
                    case "-d":
                        Disable();
                        break;
                    default:
                        Console.WriteLine("Argument not supported");
                        break;
                }
            }
        }

        public static void Backup()
        {
            string activeFile = Locations.OculusFile;
            string backupFile = Locations.OculusFile + Locations.BackupExtension;

            if (!File.Exists(backupFile))
            {
                File.Copy(activeFile, backupFile, true);
            }
        }

        public static void Enable()
        {
            File.Copy(Locations.OculusKillerFile, Locations.OculusFile, true);
        }

        public static void Disable()
        {
            File.Copy(Locations.OculusBackupFile, Locations.OculusFile, true);
        }
    }
}