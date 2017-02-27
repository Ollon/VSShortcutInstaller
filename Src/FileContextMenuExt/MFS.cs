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


internal enum MFS : uint
{
    MFS_ENABLED = 0x00000000,
    MFS_UNCHECKED = 0x00000000,
    MFS_UNHILITE = 0x00000000,
    MFS_GRAYED = 0x00000003,
    MFS_DISABLED = 0x00000003,
    MFS_CHECKED = 0x00000008,
    MFS_HILITE = 0x00000080,
    MFS_DEFAULT = 0x00001000
}
