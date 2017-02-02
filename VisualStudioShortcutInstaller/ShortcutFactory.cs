using IWshRuntimeLibrary;
using Microsoft.VisualStudio.Setup.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VisualStudioShortcutInstaller.Setup;

namespace VisualStudioShortcutInstaller
{
    public static class ShortcutFactory
    {
        public static string InstanceId
        {
            get
            {
                SetupInstance instance = SetupEnvironment.GetSetupInstance();
                return instance.InstanceId;
            }
        }

        public static string CmdExePath
        {
            get
            {
                string windowsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                string system32Folder = Path.Combine(windowsFolder, "System32");
                return Path.Combine(system32Folder, "cmd.exe");
            }
        }
        public static string DevEnvPath
        {
            get
            {
                SetupInstance instance = SetupEnvironment.GetSetupInstance();
                string installFolder = instance.InstallationPath;
                return Path.Combine(installFolder, "Common7", "IDE", "devenv.exe");
            }
        }

        public static string VsDevCmdBatPath
        {
            get
            {
                SetupInstance instance = SetupEnvironment.GetSetupInstance();
                string installFolder = instance.InstallationPath;
                return Path.Combine(installFolder, "Common7", "Tools", "VsDevCmd.bat");
            }
        }

        public static string VsMSBuildCmdBatPath
        {
            get
            {
                SetupInstance instance = SetupEnvironment.GetSetupInstance();
                string installFolder = instance.InstallationPath;
                return Path.Combine(installFolder, "Common7", "Tools", "VsMSBuildCmd.bat");
            }
        }

        public static string VSShellTemplateIconPath
        {
            get
            {
                SetupInstance instance = SetupEnvironment.GetSetupInstance();
                string installFolder = instance.InstallationPath;
                string vsshellTemplateFolder = Path.Combine(installFolder, @"Common7\IDE\ProjectTemplates\Extensibility\1033\VSShellTemplate");
                return Path.Combine(vsshellTemplateFolder, "VSShellTemplate.ico");
            }
        }

        public static string CreateExpInstancePath
        {
            get
            {
                SetupInstance instance = SetupEnvironment.GetSetupInstance();
                string installFolder = instance.InstallationPath;
                return Path.Combine(installFolder, "VSSDK", "VisualStudioIntegration", "Tools", "Bin", "CreateExpInstance.exe");
            }
        }
        public static IWshShortcut Create(string name, string description, string iconLocation, string targetPath, string arguments)
        {
            string linkAddress = CreateDesktopLinkAddress(name);
            Shortcut shortcut = Shortcut.Create(linkAddress);
            shortcut.Description = description;
            shortcut.Arguments = arguments;
            shortcut.TargetPath = targetPath;
            shortcut.IconLocation = iconLocation;
            shortcut.Save();
            return shortcut;
        }

        private static string CreateDesktopLinkAddress(string name)
        {
            string desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string visualStudioDirectory = Path.Combine(desktopDirectory, "VisualStudio");
            if (!Directory.Exists(visualStudioDirectory))
                Directory.CreateDirectory(visualStudioDirectory);
            string path = string.Format(@"{0}\{1}.lnk", visualStudioDirectory, name);
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
            return path;
        }

        private static string GetVisualStudioInstallationFolder()
        {
            SetupInstance instance = SetupEnvironment.GetSetupInstance();
            return instance.InstallationPath;
        }

        private static string GetVisualStudioInstanceId()
        {
            SetupInstance instance = SetupEnvironment.GetSetupInstance();
            return instance.InstanceId;
        }

        private class Shortcut : IWshShortcut
        {
            private IWshShortcut _shortcut;

            public static Shortcut Create(string linkAddress)
            {
                WshShell shell = new WshShell();
                IWshShortcut shortcut = shell.CreateShortcut(linkAddress);
                return new Shortcut(shortcut);
            }

            private Shortcut(IWshShortcut shortcut)
            {
                _shortcut = shortcut;
            }

            public void Load(string PathLink)
            {
                _shortcut.Load(PathLink);
            }

            public void Save()
            {
                _shortcut.Save();
            }

            public string FullName => _shortcut.FullName;

            public string Arguments
            {
                get
                {
                    return _shortcut.Arguments;
                }

                set
                {
                    _shortcut.Arguments = value;
                }
            }

            public string Description
            {
                get
                {
                    return _shortcut.Description;
                }

                set
                {
                    _shortcut.Description = value;
                }
            }

            public string Hotkey
            {
                get
                {
                    return _shortcut.Hotkey;
                }

                set
                {
                    _shortcut.Hotkey = value;
                }
            }

            public string IconLocation
            {
                get
                {
                    return _shortcut.IconLocation;
                }

                set
                {
                    _shortcut.IconLocation = value;
                }
            }

            public string RelativePath
            {
                set
                {
                    _shortcut.RelativePath = value;
                }
            }

            public string TargetPath
            {
                get
                {
                    return _shortcut.TargetPath;
                }

                set
                {
                    _shortcut.TargetPath = value;
                }
            }

            public int WindowStyle
            {
                get
                {
                    return _shortcut.WindowStyle;
                }

                set
                {
                    _shortcut.WindowStyle = value;
                }
            }

            public string WorkingDirectory
            {
                get
                {
                    return _shortcut.WorkingDirectory;
                }

                set
                {
                    _shortcut.WorkingDirectory = value;
                }
            }
        }
    }
}