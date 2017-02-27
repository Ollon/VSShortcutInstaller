using Microsoft.Win32.Shell.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Win32.Shell.Model
{
    internal abstract class ContextMenu
    {
        public virtual string MUIVerb { get; }

        IReadOnlyList<MenuCommand> Commands { get; }
    }

    internal class MenuCommand
    {
        public string MUIVerb { get; }
        public string Icon { get; }
        public CommandFlags CommandFlags { get; }
        public string Command { get; }

        public IReadOnlyList<SubMenuCommand> SubCommands { get; }
    }

    internal class SubMenuCommand : MenuCommand
    {
        public MenuCommand Parent { get; }
    }

    internal class CascadeMenu : ContextMenu
    {

    }
}
