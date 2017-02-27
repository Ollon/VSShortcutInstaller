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





[ComImport(), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("000214e8-0000-0000-c000-000000000046")]
internal interface IShellExtInit
{
    void Initialize(
        IntPtr /*LPCITEMIDLIST*/ pidlFolder,
        IntPtr /*LPDATAOBJECT*/ pDataObj,
        IntPtr /*HKEY*/ hKeyProgID);
}
