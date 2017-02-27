using System;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Win32.Shell.Commands
{
    [Cmdlet(VerbsCommon.New, "ContextMenu")]
    public class NewContextMenuCommand : PSCmdlet
    {
        [Parameter]
        public string MUIVerb { get; set; }

        [Parameter(ParameterSetName = "ByProgID")]
        public string ProgID { get; set; }


        protected override void ProcessRecord()
        {
            RegistryKey key = null;

            switch (ParameterSetName)
            {
                case "ByProgID":
                    {
                        key = Registry.ClassesRoot.OpenSubKey(ProgID);
                        break;
                    }
                default:
                    key = Registry.ClassesRoot.OpenSubKey("*");
                    break;
            }

            key.SetValue(null, null);

            if (!key.GetSubKeyNames().Contains("ExtendedSubCommandsKey"))
            {
                RegistryKey extendedKey =  key.CreateSubKey("ExtendedSubCommandsKey");
                RegistryKey shellKey = extendedKey.CreateSubKey("Shell");

                
            }
        }
    }
}
