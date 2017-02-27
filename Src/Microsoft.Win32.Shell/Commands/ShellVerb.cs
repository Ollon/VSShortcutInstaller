using System.Collections.Generic;

namespace Microsoft.Win32.Shell
{
    public class ShellVerb
    {

        private static RegistryKey _key;

        public static ShellVerb From(RegistryKey key)
        {

            string[] splits = key.Name.Split('\\');
            int count = splits.Length;
            string name = splits[count - 1];

            _key = key;

            string command = key.OpenSubKey("command")?.GetValue(null, "<no default command present>").ToString();
            IEnumerable<string> keyNames = key.GetValueNames();
            

            return new ShellVerb(keyNames, name, new ShellCommand(command));
        }
        public ShellVerb(IEnumerable<string> propertyNames, string name, ShellCommand command)
        {

            Properties = ShellVerbProperties.From(_key);
            Name = name;
            Command = command;
        }

        public IShellVerbProperties Properties { get; private set; }
        public string Name { get; private set; }

        public ShellCommand Command { get; private set; }

        public void Register()
        {

        }

        public void UnRegister()
        {

        }
    }
}
