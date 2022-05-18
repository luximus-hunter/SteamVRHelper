using Microsoft.Win32;

namespace NoOculusToggle
{
    internal static class Locations
    {
        public static string Root = @"C:\SteamVRHelper";
        public static string TemplateDirectory = Path.Combine(Root, "TemplateFiles");

        public static string BackupExtension = ".backup";

        #region Steam

        public static string Steam = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
        public static string SteamGames = Path.Combine(Path.GetFullPath(Steam), @"steamapps\common\");

        #endregion

        #region Oculus

        public static string OculusDirectory = @"C:\Program Files\Oculus\Support\oculus-dash\dash\bin";
        public static string OculusFileName = "OculusDash.exe";
        public static string OculusFile = Path.Combine(OculusDirectory, OculusFileName);
        public static string OculusKillerFile = Path.Combine(TemplateDirectory, OculusFileName);
        public static string OculusBackupFile = Path.Combine(OculusDirectory, OculusFileName + BackupExtension);

        #endregion

        #region OpenVR

        public static string OpenvrDllFileName = "openvr_api.dll";
        public static string OpenvrConfigFileName = "openvr_mod.cfg";
        public static string OpenvrLogFileName = "openvr_mod.log";
        public static string OpenvrDllFile = Path.Combine(TemplateDirectory, OpenvrDllFileName);
        public static string OpenvrConfigFile = Path.Combine(TemplateDirectory, OpenvrConfigFileName);

        #endregion

        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
