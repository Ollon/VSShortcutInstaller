using System;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Win32.Shell.Commands
{
    [Cmdlet(VerbsCommon.New, "Verb")]
    public class NewVerbCommand : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        public string KeyName { get; set; }

        [Parameter(Mandatory = true)]
        public string VerbName { get; set; }

        [Parameter]
        public string MUIVerb { get; set; }

        [Parameter]
        public string Icon { get; set; }

        [Parameter]
        public string Command { get; set; }

        [Parameter]
        public SwitchParameter Force { get; set; }

        protected override void ProcessRecord()
        {
            if (string.IsNullOrEmpty(MUIVerb))
            {
                MUIVerb = VerbName;
            }

            RegistryKey key = null;
            if (Force)
            {
                if (RegistryHelper.ShellKeyExists(KeyName))
                {
                    WriteWarning($"Removing Registry Key {KeyName} because it already exists and 'Force' was specified...");
                    RegistryHelper.CommandStoreShell.DeleteSubKeyTree(KeyName, false);
                }
            }

            key = RegistryHelper.CommandStoreShell.CreateSubKey(KeyName);

            key.SetValue("VerbName", VerbName);

            key.SetValue("MUIVerb", MUIVerb);

            if (!string.IsNullOrEmpty(Icon))
            {
                key.SetValue("Icon", Icon);
            }

            if (!string.IsNullOrEmpty(Command))
            {
                RegistryKey commandKey = key.CreateSubKey("command");

                commandKey.SetValue(null, Command);
            }

            ShellVerb verb = ShellVerb.From(RegistryHelper.CommandStoreShell.OpenSubKey(KeyName));

            WriteObject(verb);

            WriteVerbose($"Created new Shell Verb with key name '{KeyName}' at registry key '{key}'");
        }
    }
}
