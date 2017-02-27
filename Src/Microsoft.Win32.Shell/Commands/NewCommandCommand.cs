using System;
using System.Management.Automation;

namespace Microsoft.Win32.Shell.Commands
{
    [Cmdlet(VerbsCommon.New, "Command")]
    public class NewCommandCommand : PSCmdlet
    {
        [Parameter]
        [Alias("Name")]
        public string KeyName { get; set; }

        [Parameter]
        [Alias("Verb")]
        public string MUIVerb { get; set; }

        [Parameter]
        [Alias("Flags")]
        public CommandFlags CommandFlags { get; set; }

        [Parameter]
        public string Command { get; set; }

        protected override void ProcessRecord()
        {

            WriteObject(new ShellCommand(KeyName, MUIVerb, CommandFlags, Command));
        }
    }
}
