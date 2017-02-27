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
using Microsoft.Win32;

internal class ShellExtReg
{
    /// <summary>
    /// Register the context menu handler.
    /// </summary>
    /// <param name="clsid">The CLSID of the component.</param>
    /// <param name="fileType">
    /// The file type that the context menu handler is associated with. For 
    /// example, '*' means all file types; '.txt' means all .txt files. The 
    /// parameter must not be NULL or an empty string. 
    /// </param>
    /// <param name="friendlyName">The friendly name of the component.</param>
    public static void RegisterShellExtContextMenuHandler(Guid clsid,
        string fileType, string friendlyName)
    {
        if (clsid == Guid.Empty)
        {
            throw new ArgumentException("clsid must not be empty");
        }
        if (string.IsNullOrEmpty(fileType))
        {
            throw new ArgumentException("fileType must not be null or empty");
        }

        // If fileType starts with '.', try to read the default value of the 
        // HKCR\<File Type> key which contains the ProgID to which the file type 
        // is linked.
        if (fileType.StartsWith("."))
        {
            using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(fileType))
            {
                if (key != null)
                {
                    // If the key exists and its default value is not empty, use 
                    // the ProgID as the file type.
                    string defaultVal = key.GetValue(null) as string;
                    if (!string.IsNullOrEmpty(defaultVal))
                    {
                        fileType = defaultVal;
                    }
                }
            }
        }

        // Create the key HKCR\<File Type>\shellex\ContextMenuHandlers\{<CLSID>}.
        string keyName = string.Format(@"{0}\shellex\ContextMenuHandlers\{1}",
            fileType, clsid.ToString("B"));
        using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(keyName))
        {
            // Set the default value of the key.
            if (key != null && !string.IsNullOrEmpty(friendlyName))
            {
                key.SetValue(null, friendlyName);
            }
        }
    }

    /// <summary>
    /// Unregister the context menu handler.
    /// </summary>
    /// <param name="clsid">The CLSID of the component.</param>
    /// <param name="fileType">
    /// The file type that the context menu handler is associated with. For 
    /// example, '*' means all file types; '.txt' means all .txt files. The 
    /// parameter must not be NULL or an empty string. 
    /// </param>
    public static void UnregisterShellExtContextMenuHandler(Guid clsid,
        string fileType)
    {
        if (clsid == null)
        {
            throw new ArgumentException("clsid must not be null");
        }
        if (string.IsNullOrEmpty(fileType))
        {
            throw new ArgumentException("fileType must not be null or empty");
        }

        // If fileType starts with '.', try to read the default value of the 
        // HKCR\<File Type> key which contains the ProgID to which the file type 
        // is linked.
        if (fileType.StartsWith("."))
        {
            using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(fileType))
            {
                if (key != null)
                {
                    // If the key exists and its default value is not empty, use 
                    // the ProgID as the file type.
                    string defaultVal = key.GetValue(null) as string;
                    if (!string.IsNullOrEmpty(defaultVal))
                    {
                        fileType = defaultVal;
                    }
                }
            }
        }

        // Remove the key HKCR\<File Type>\shellex\ContextMenuHandlers\{<CLSID>}.
        string keyName = string.Format(@"{0}\shellex\ContextMenuHandlers\{1}",
            fileType, clsid.ToString("B"));
        Registry.ClassesRoot.DeleteSubKeyTree(keyName, false);
    }
}
