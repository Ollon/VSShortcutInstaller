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

        public string KeyName { get; }
        public string MUIVerb { get; }
        public CommandFlags CommandFlags { get; }
        public string Command { get; }

        public override string ToString()
        {
            return Command;
        }
    }
}
