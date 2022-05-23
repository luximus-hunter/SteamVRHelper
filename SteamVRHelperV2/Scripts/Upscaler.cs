﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SteamVRHelperV2.Scripts
{
    internal enum UpscaleAlgorithm
    {
        FSR = 0,
        NIS = 1
    }

    internal class Upscaler
    {
        private bool inited;
        private bool enabled;

        private UpscaleAlgorithm algorithm;
        private int renderScale;
        private int sharpness;
        private List<string> config;

        private Library _l = new();

        public Upscaler()
        {
            if (!BackedUp())
            {
                Backup();
            }

            if (File.Exists(Path.Combine(Locations.OpenvrDllFile)) &&
               File.Exists(Path.Combine(Locations.OpenvrConfigFile)))
            {
                inited = true;
            }

            if (inited)
            {
                config = File.ReadAllLines(Locations.OpenvrConfigFile).ToList();

                #region Read Config

                if (CheckConfigLine(9, "true"))
                {
                    algorithm = UpscaleAlgorithm.NIS;
                }
                else
                {
                    algorithm = UpscaleAlgorithm.FSR;
                }

                renderScale = ReadConfigLine(21);
                sharpness = ReadConfigLine(24);

                #endregion
            }
        }

        public bool BackedUp()
        {
            bool backedUp = true;

            foreach (Game game in _l.Games)
            {
                foreach (string path in game.Paths)
                {
                    string backupFile = Path.Combine(path, Locations.OpenvrDllFileName + Locations.BackupExtension);

                    if (!File.Exists(backupFile))
                    {
                        backedUp = false;
                    }
                }
            }

            return backedUp;
        }

        public bool Enabled()
        {
            bool enabled = true;

            foreach (Game game in _l.Games)
            {
                foreach (string path in game.Paths)
                {
                    string activeFile = Path.Combine(path, Locations.OpenvrDllFileName);

                    if(File.ReadAllLines(activeFile).Length != File.ReadAllLines(Locations.OpenvrDllFile).Length)
                    {
                        enabled = false;
                    }
                }
            }

            this.enabled = enabled;

            return enabled;
        }

        /// <summary>
        /// Creates backup files for all games if they don't exist.
        /// </summary>
        public void Backup()
        {
            foreach (Game game in _l.Games)
            {
                foreach (string path in game.Paths)
                {
                    string activeFile = Path.Combine(path, Locations.OpenvrDllFileName);
                    string backupFile = Path.Combine(path, Locations.OpenvrDllFileName + Locations.BackupExtension);

                    if (!File.Exists(backupFile))
                    {
                        File.Copy(activeFile, backupFile, true);
                    }
                }
            }
        }

        /// <summary>
        /// Saves and applies all newly set settings.
        /// </summary>
        public void Apply()
        {
            // Edit config file
            EditConfigLine(9, (algorithm == UpscaleAlgorithm.FSR ? "false" : "true") + ",");
            EditConfigLine(21, renderScale == 100 ? "1.00" : "0." + renderScale.ToString() + ",");
            EditConfigLine(24, sharpness == 100 ? "1.00" : "0." + sharpness.ToString() + ",");

            // Write to config file
            try
            {
                File.WriteAllLines(Locations.OpenvrConfigFile, config);
            }
            catch (Exception)
            {
                //MessageBox.Show("Couldn't save new config");
            }

            // Add config file to games
            foreach (Game game in _l.Games)
            {
                foreach (string path in game.Paths)
                {
                    string configFile = Path.Combine(path, Locations.OpenvrConfigFileName);

                    File.Copy(Locations.OpenvrConfigFile, configFile, true);
                }
            }
        }

        /// <summary>
        /// Enables game upscaling.
        /// </summary>
        public void Enable()
        {
            Backup();

            foreach (Game game in _l.Games)
            {
                foreach (string path in game.Paths)
                {
                    string activeFile = Path.Combine(path, Locations.OpenvrDllFileName);
                    string configFile = Path.Combine(path, Locations.OpenvrConfigFileName);

                    File.Copy(Locations.OpenvrDllFile, activeFile, true);
                    File.Copy(Locations.OpenvrConfigFile, configFile, true);
                }
            }
        }

        /// <summary>
        /// Disables game upscaling.
        /// </summary>
        public void Disable()
        {
            foreach (Game game in _l.Games)
            {
                foreach (string path in game.Paths)
                {
                    string activeFile = Path.Combine(path, Locations.OpenvrDllFileName);
                    string backupFile = Path.Combine(path, Locations.OpenvrDllFileName + Locations.BackupExtension);

                    // backup != killer -> restore
                    if (File.ReadAllBytes(backupFile) != File.ReadAllBytes(Locations.OpenvrDllFile))
                    {
                        File.Copy(backupFile, activeFile, true);
                    }
                }
            }
        }

        /// <summary>
        /// !!! Will remove ALL files related to upscaling. !!!
        /// </summary>
        public void Restore()
        {
            Disable();

            foreach (Game game in _l.Games)
            {
                foreach (string path in game.Paths)
                {
                    string backupFile = Path.Combine(path, Locations.OpenvrDllFileName + Locations.BackupExtension);
                    string configFile = Path.Combine(path, Locations.OpenvrConfigFileName);
                    string logFile = Path.Combine(path, Locations.OpenvrLogFileName);

                    File.Delete(backupFile);
                    File.Delete(configFile);
                    File.Delete(logFile);
                }
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

        public UpscaleAlgorithm Algorithm
        {
            get => algorithm;
            set => algorithm = value;
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
