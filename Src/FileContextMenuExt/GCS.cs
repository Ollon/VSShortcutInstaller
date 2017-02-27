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


internal enum GCS : uint
{
    GCS_VERBA = 0x00000000,
    GCS_HELPTEXTA = 0x00000001,
    GCS_VALIDATEA = 0x00000002,
    GCS_VERBW = 0x00000004,
    GCS_HELPTEXTW = 0x00000005,
    GCS_VALIDATEW = 0x00000006,
    GCS_VERBICONW = 0x00000014,
    GCS_UNICODE = 0x00000004
}
