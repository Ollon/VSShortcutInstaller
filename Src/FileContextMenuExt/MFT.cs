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


internal enum MFT : uint
{
    MFT_STRING = 0x00000000,
    MFT_BITMAP = 0x00000004,
    MFT_MENUBARBREAK = 0x00000020,
    MFT_MENUBREAK = 0x00000040,
    MFT_OWNERDRAW = 0x00000100,
    MFT_RADIOCHECK = 0x00000200,
    MFT_SEPARATOR = 0x00000800,
    MFT_RIGHTORDER = 0x00002000,
    MFT_RIGHTJUSTIFY = 0x00004000
}
