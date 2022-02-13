using Microsoft.Win32;

namespace Juggler
{
    public class JarRegistry : IRegistry<string>
    {
        private readonly string postfix = "javaw.exe\" -jar \"%1\" %*";

        public void Change(string newValue)
        {
            using (RegistryKey key = Registry.ClassesRoot.OpenSubKey("jarfile\\shell\\open\\command", true))
            {
                if (key != null)
                {
                    string val = "\"" + newValue + "\\" + postfix;
                    key.SetValue("", val, RegistryValueKind.String);
                }
            }
        }
    }
}
