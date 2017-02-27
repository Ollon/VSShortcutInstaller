using Microsoft.Win32.Shell.Commands;

namespace Microsoft.Win32.Shell
{
    public class ShellCommand
    {
        public ShellCommand(string @default)
        {
            if (string.IsNullOrEmpty(@default))
            {
                Command = "<empty command>";
            }
            else
            {
                Command = @default;
            }
           
        }

        public ShellCommand(string keyName, string mUIVerb, CommandFlags commandFlags, string command)
        {
            KeyName = keyName;
            MUIVerb = mUIVerb;
            CommandFlags = commandFlags;
            Command = command;
        }

        public string KeyName { get; private set; }
        public string MUIVerb { get; private set; }
        public CommandFlags CommandFlags { get; private set; }
        public string Command { get; private set; }

        public override string ToString()
        {
            return Command;
        }
    }
}
