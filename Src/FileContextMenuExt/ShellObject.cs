using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShellContextMenuHanlderExample
{



    public interface IShellObject
    {

    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("5ACC3CB0-616B-4F3A-A904-3A58EE90D152")]
    public class ShellObject : IShellObject
    {
    }
}
