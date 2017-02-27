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
internal enum CMF : uint
{
    CMF_NORMAL = 0x00000000,
    CMF_DEFAULTONLY = 0x00000001,
    CMF_VERBSONLY = 0x00000002,
    CMF_EXPLORE = 0x00000004,
    CMF_NOVERBS = 0x00000008,
    CMF_CANRENAME = 0x00000010,
    CMF_NODEFAULT = 0x00000020,
    CMF_INCLUDESTATIC = 0x00000040,
    CMF_ITEMMENU = 0x00000080,
    CMF_EXTENDEDVERBS = 0x00000100,
    CMF_DISABLEDVERBS = 0x00000200,
    CMF_ASYNCVERBSTATE = 0x00000400,
    CMF_OPTIMIZEFORINVOKE = 0x00000800,
    CMF_SYNCCASCADEMENU = 0x00001000,
    CMF_DONOTPICKDEFAULT = 0x00002000,
    CMF_RESERVED = 0xFFFF0000
}
