namespace NoOculusToggle
{
    internal static class Locations
    {
        public static string Root = @"C:\SteamVRHelper";
        public static string TemplateDirectory = Path.Combine(Root, "TemplateFiles");

        public static string BackupExtension = ".backup";

        #region Oculus

        public static string OculusDirectory = @"C:\Program Files\Oculus\Support\oculus-dash\dash\bin";
        public static string OculusFileName = "OculusDash.exe";
        public static string OculusFile = Path.Combine(OculusDirectory, OculusFileName);
        public static string OculusKillerFile = Path.Combine(TemplateDirectory, OculusFileName);
        public static string OculusBackupFile = Path.Combine(OculusDirectory, OculusFileName + BackupExtension);

        #endregion
    }
}
