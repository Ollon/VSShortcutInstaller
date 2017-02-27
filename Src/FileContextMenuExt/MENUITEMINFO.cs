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
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct MENUITEMINFO
{
    public uint cbSize;
    public MIIM fMask;
    public MFT fType;
    public MFS fState;
    public uint wID;
    public IntPtr hSubMenu;
    public IntPtr hbmpChecked;
    public IntPtr hbmpUnchecked;
    public UIntPtr dwItemData;
    [MarshalAs(UnmanagedType.LPTStr)]
    public string dwTypeData;
    public uint cch;
    public IntPtr hbmpItem;
}
