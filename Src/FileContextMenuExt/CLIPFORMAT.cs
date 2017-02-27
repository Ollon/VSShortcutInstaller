﻿/********************************** Module Header **********************************\
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


internal enum CLIPFORMAT : uint
{
    CF_TEXT = 1,
    CF_BITMAP = 2,
    CF_METAFILEPICT = 3,
    CF_SYLK = 4,
    CF_DIF = 5,
    CF_TIFF = 6,
    CF_OEMTEXT = 7,
    CF_DIB = 8,
    CF_PALETTE = 9,
    CF_PENDATA = 10,
    CF_RIFF = 11,
    CF_WAVE = 12,
    CF_UNICODETEXT = 13,
    CF_ENHMETAFILE = 14,
    CF_HDROP = 15,
    CF_LOCALE = 16,
    CF_MAX = 17,

    CF_OWNERDISPLAY = 0x0080,
    CF_DSPTEXT = 0x0081,
    CF_DSPBITMAP = 0x0082,
    CF_DSPMETAFILEPICT = 0x0083,
    CF_DSPENHMETAFILE = 0x008E,

    CF_PRIVATEFIRST = 0x0200,
    CF_PRIVATELAST = 0x02FF,

    CF_GDIOBJFIRST = 0x0300,
    CF_GDIOBJLAST = 0x03FF
}
