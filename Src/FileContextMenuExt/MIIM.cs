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
internal enum MIIM : uint
{
    MIIM_STATE = 0x00000001,
    MIIM_ID = 0x00000002,
    MIIM_SUBMENU = 0x00000004,
    MIIM_CHECKMARKS = 0x00000008,
    MIIM_TYPE = 0x00000010,
    MIIM_DATA = 0x00000020,
    MIIM_STRING = 0x00000040,
    MIIM_BITMAP = 0x00000080,
    MIIM_FTYPE = 0x00000100
}
