namespace SteamVRHelper
{
    internal enum OpenVRUpscaler
    {
        FSR = 0,
        NIS = 1
    }

    internal class OpenVR
    {
        private bool inited;
        private bool enabled;

        private OpenVRUpscaler upscaler;
        private int renderScale;
        private int sharpness;
        private List<string> config;

        private Library library;

        public OpenVR() {
            if(File.Exists(Path.Combine(Locations.OpenvrDllFile)) &&
               File.Exists(Path.Combine(Locations.OpenvrConfigFile)))
            {
                inited = true;
            }

            if (inited)
            {
                library = new Library();

                config = File.ReadAllLines(Locations.OpenvrConfigFile).ToList();

                #region Read Config

                if (CheckConfigLine(9, "true"))
                {
                    upscaler = OpenVRUpscaler.NIS;
                }
                else
                {
                    upscaler = OpenVRUpscaler.FSR;
                }

                renderScale = ReadConfigLine(21);
                sharpness = ReadConfigLine(24);

                #endregion
            }
        }

        public void Backup()
        {
            foreach (Game game in library.Games)
            {
                foreach (string path in game.Paths)
                {
                    int index = game.Paths.IndexOf(path);

                    string backupDirectory = Path.Combine(Locations.GamesBackupDirectory, game.Name, index.ToString());
                    string backupFile = Path.Combine(backupDirectory, Locations.OpenvrDllFileName);

                    if (!File.Exists(backupFile))
                    {
                        Directory.CreateDirectory(backupDirectory);
                        File.Copy(Path.Combine(path, Locations.OpenvrDllFileName), backupFile);
                    }

                    File.Delete(Path.Combine(path, Locations.OpenvrDllFileName));
                    

                    File.Copy(Locations.OpenvrDllFile, Path.Combine(path, Locations.OpenvrDllFileName), true);
                    File.Copy(Locations.OpenvrConfigFile, Path.Combine(path, Locations.OpenvrConfigFileName), true);
                }                
            }            
        }

        public void Restore()
        {
            foreach (Game game in library.Games)
            {
                foreach (string path in game.Paths)
                {
                    int index = game.Paths.IndexOf(path);

                    string backupDirectory = Path.Combine(Locations.GamesBackupDirectory, game.Name, index.ToString());
                    string backupFile = Path.Combine(backupDirectory, Locations.OpenvrDllFileName);

                    File.Delete(Path.Combine(path, Locations.OpenvrDllFileName));
                    File.Delete(Path.Combine(path, Locations.OpenvrConfigFileName));
                    File.Delete(Path.Combine(path, Locations.OpenvrLogFileName));

                    File.Move(backupFile, Path.Combine(path, Locations.OpenvrDllFileName), true);
                    Directory.Delete(backupDirectory);
                }

                Directory.Delete(Path.Combine(Locations.GamesBackupDirectory, game.Name));
            }            
        }

        public void Save()
        {
            EditConfigLine(9, (upscaler == OpenVRUpscaler.FSR ? "false" : "true") + ",");
            EditConfigLine(21, renderScale == 100 ? "1.00" : "0." + renderScale.ToString() + ",");
            EditConfigLine(24, sharpness == 100 ? "1.00" : "0." + sharpness.ToString() + ",");

            try
            {
                File.WriteAllLines(Locations.OpenvrConfigFile, config);

                foreach (Game game in library.Games)
                {
                    foreach (string path in game.Paths)
                    {
                        File.Copy(Locations.OpenvrConfigFile, Path.Combine(path, Locations.OpenvrConfigFileName), true);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't save new files.");
            }
        }

        private bool CheckConfigLine(int lineNumber, string check)
        {
            return config[lineNumber].Contains(check);
        }

        private int ReadConfigLine(int lineNumber)
        {
            string line = config[lineNumber];
            string value = line.Split(':')[1].Replace(',', ' ').Trim();

            if (value.Length == 3)
            {
                return (int)double.Parse(value) * 10;
            }
            else
            {
                return (int)double.Parse(value);
            }
        }

        private void EditConfigLine(int lineNumber, string value)
        {
            string oldLine = config[lineNumber];
            string newLine = oldLine.Split(':')[0] + ": " + value;
            config[lineNumber] = newLine;
        }

        #region Getters and Setters

        public bool Inited
        {
            get => inited;
        }

        public bool Enabled
        {
            get => enabled;
            set => enabled = value;
        }

        public OpenVRUpscaler Upscaler
        {
            get => upscaler;
            set => upscaler = value;
        }

        public int RenderScale
        {
            get => renderScale;
            set => renderScale = value;
        }

        public int Sharpness
        {
            get => sharpness;
            set => sharpness = value;
        }

        #endregion
    }
}
