using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Win32.Shell
{
    public static class RegistryHelper
    {
        private const string CommandStoreKeyString = @"Software\Microsoft\Windows\CurrentVersion\Explorer\CommandStore";
        public static RegistryKey CommandStore
        {
            get
            {
                return Registry.LocalMachine.OpenSubKey(CommandStoreKeyString, true);
            }
        }

        public static IEnumerable<string> ShellKeyNames
        {
            get
            {
                return CommandStoreShell.GetSubKeyNames().AsEnumerable();
            }
        }
        public static RegistryKey CommandStoreShell
        {
            get
            {
                return CommandStore.OpenSubKey("Shell",true);
            }
        }

        public static bool ShellKeyExists(string name)
        {
            return ShellKeyNames.Contains(name);
        }

        public static IEnumerable<ShellVerb> GetShellVerbs()
        {
            foreach (string keyName in CommandStoreShell.GetSubKeyNames())
            {
                RegistryKey key = CommandStoreShell.OpenSubKey(keyName);

                ShellVerb verb = ShellVerb.From(key);

                yield return verb;
            }
        }

        public static ShellVerb GetShellVerb(string name)
        {
            ShellVerb verb = null;
            foreach (ShellVerb shellVerb in GetShellVerbs())
            {
                if (shellVerb.Name == name)
                {
                    verb = shellVerb;
                }
            }

            return verb;
        }
    }
}
