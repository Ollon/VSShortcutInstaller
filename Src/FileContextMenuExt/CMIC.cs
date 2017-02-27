/********************************** Module Header **********************************\
Module Name:  ShellExtLib.cs
Project:      CSShellExtContextMenuHandler
Copyright (c) Microsoft Corporation.

The file declares the imported Shell interfaces: IShellExtInit and IContextMenu, 
implements the helper functions for registering and unregistering a shell context 
menu handler, and declares the Win32 enums, structs, consts, and functions used by 
the code sample.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***********************************************************************************/


using System;
[Flags]
internal enum CMIC : uint
{
    CMIC_MASK_ICON = 0x00000010,
    CMIC_MASK_HOTKEY = 0x00000020,
    CMIC_MASK_NOASYNC = 0x00000100,
    CMIC_MASK_FLAG_NO_UI = 0x00000400,
    CMIC_MASK_UNICODE = 0x00004000,
    CMIC_MASK_NO_CONSOLE = 0x00008000,
    CMIC_MASK_ASYNCOK = 0x00100000,
    CMIC_MASK_NOZONECHECKS = 0x00800000,
    CMIC_MASK_FLAG_LOG_USAGE = 0x04000000,
    CMIC_MASK_SHIFT_DOWN = 0x10000000,
    CMIC_MASK_PTINVOKE = 0x20000000,
    CMIC_MASK_CONTROL_DOWN = 0x40000000
}
