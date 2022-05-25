using System.Reflection;
using System.Resources;

namespace SteamVRHelperV2.Scripts
{
    public class Language
    {
        private ResourceManager _rm;
        private string _s;

        public Language()
        {
            _rm = new ResourceManager("SteamVRHelperV2.Language.EN", Assembly.GetExecutingAssembly());
            _s = "";
        }

        public Language(string section)
        {
            _rm = new ResourceManager("SteamVRHelperV2.Language.EN", Assembly.GetExecutingAssembly());
            _s = section;
        }

        public string GetString(string str)
        {
            return _rm.GetString(_s + "." + str);
        }

        public string GetRawString(string str)
        {
            return _rm.GetString(str);
        }
    }
}
