using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;
using System.IO;
namespace VisualStudioShortcutInstaller
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            string instanceId = ShortcutFactory.InstanceId;
            IWshShortcut startvs = ShortcutFactory.Create(
                "Start VS",
                "Starts the regular Visual Studio Instance",
                ShortcutFactory.DevEnvExePath,
                ShortcutFactory.DevEnvExePath,
                "");
            IWshShortcut startexp = ShortcutFactory.Create(
                "Start Exp",
                "Starts the experimental instance of Visual Studio",
                ShortcutFactory.DevEnvExePath,
                ShortcutFactory.DevEnvExePath,
                "/RootSuffix Exp");
            IWshShortcut startroslyn = ShortcutFactory.Create(
                "Start Roslyn",
                "Starts the Roslyn experimental instance of Visual Studio",
                ShortcutFactory.DevEnvExePath,
                ShortcutFactory.DevEnvExePath,
                "/RootSuffix Roslyn");
            IWshShortcut startroslyndev = ShortcutFactory.Create(
                "Start RoslynDev",
                "Starts the Roslyn Developer experimental instance of Visual Studio",
                ShortcutFactory.DevEnvExePath,
                ShortcutFactory.DevEnvExePath,
                "/RootSuffix RoslynDev"
               );
            IWshShortcut vsdevcmd = ShortcutFactory.Create(
                "Developer Command Prompt",
                "Visual Studio Developer Command Prompt",
                ShortcutFactory.CmdExePath,
                ShortcutFactory.CmdExePath,
                $" /k \"{ShortcutFactory.VsDevCmdBatPath}\""
                );
            IWshShortcut msbuildcmd = ShortcutFactory.Create(
                "MSBuild Command Prompt",
                "MSBuild Command Prompt",
                ShortcutFactory.CmdExePath,
                ShortcutFactory.CmdExePath,
                $" /k \"{ShortcutFactory.VsMSBuildCmdBatPath}\""
                );
            IWshShortcut resetExp = ShortcutFactory.Create(
                "Reset Exp",
                "Resets the Experimental instance (Exp) of Visual Studio.",
                ShortcutFactory.VSShellTemplateIconPath,
                ShortcutFactory.CmdExePath,
                $" /c \"{ShortcutFactory.CreateExpInstancePath}\" /Reset /VSInstance=15.0_{instanceId} /RootSuffix=RoslynDev && PAUSE"
                );
            IWshShortcut resetRoslyn = ShortcutFactory.Create(
                "Reset Roslyn",
                "Resets the Roslyn instance (Roslyn) of Visual Studio.",
                ShortcutFactory.VSShellTemplateIconPath,
                ShortcutFactory.CmdExePath,
                $" /c \"{ShortcutFactory.CreateExpInstancePath}\" /Reset /VSInstance=15.0_{instanceId} /RootSuffix=RoslynDev && PAUSE"
                );
            IWshShortcut resetRoslynDev = ShortcutFactory.Create(
                "Reset RoslynDev",
                "Resets the Roslyn Developer instance (RoslynDev) of Visual Studio.",
                ShortcutFactory.VSShellTemplateIconPath,
                ShortcutFactory.CmdExePath,
                $" /c \"{ShortcutFactory.CreateExpInstancePath}\" /Reset /VSInstance=15.0_{instanceId} /RootSuffix=RoslynDev && PAUSE"
                );
            IWshShortcut clearcache = ShortcutFactory.Create(
                "Clear Component Cache",
                "Clears the component cache for visual studio",
                ShortcutFactory.FileIconPath,
                ShortcutFactory.CmdExePath,
                $" /c \"{ShortcutFactory.DevEnvExePath}\" /clearcache && PAUSE"
                );
        }
    }
}
