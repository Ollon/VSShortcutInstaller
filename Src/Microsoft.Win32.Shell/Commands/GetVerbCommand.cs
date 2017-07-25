using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Win32.Shell
{
    [Cmdlet(VerbsCommon.Get, "Verb")]
    public class GetVerbCommand : PSCmdlet, IDynamicParameters
    {
        private RuntimeDefinedParameterDictionary DynamicParameters;


        [Parameter]
        public SwitchParameter Properties { get; set; }

        public RuntimeDefinedParameterDictionary GetDynamicParameters()
        {
            RuntimeDefinedParameterDictionary dictionary = new RuntimeDefinedParameterDictionary();
            Collection<Attribute> collection = new Collection<Attribute>();
            ParameterAttribute parameter = new ParameterAttribute();
            parameter.ParameterSetName = "ByName";
            collection.Add(parameter);

            IEnumerable<string> names = RegistryHelper.ShellKeyNames;

            ValidateSetAttribute validateSet = new ValidateSetAttribute(names.ToArray());

            collection.Add(validateSet);

            RuntimeDefinedParameter nameParameter = new RuntimeDefinedParameter("Name", typeof(string), collection);

            dictionary.Add("Name", nameParameter);

            DynamicParameters = dictionary;
            return dictionary;
        }
        object IDynamicParameters.GetDynamicParameters()
        {
            return GetDynamicParameters();
        }

        protected override void ProcessRecord()
        {
            if (ParameterSetName == "ByName")
            {
                string value = DynamicParameters["Name"].Value.ToString();

                ShellVerb verb = RegistryHelper.GetShellVerb(value);

                if (Properties)
                {
                    WriteObject(verb.Properties);
                }
                else
                {
                    WriteObject(verb);
                }
            }
            else
            {
                WriteObject(RegistryHelper.GetShellVerbs(), true);
            }

        }
    }
}
