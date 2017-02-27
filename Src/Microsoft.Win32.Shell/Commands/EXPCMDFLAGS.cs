namespace Microsoft.Win32.Shell.Commands
{
    public enum EXPCMDFLAGS
    {
        /// <summary>
        /// Windows 7 and later. No command flags are set.
        /// </summary>
        ECF_DEFAULT = 0x000,

        /// <summary>
        /// The command has subcommands.
        /// </summary>
        ECF_HASSUBCOMMANDS = 0x001,

        /// <summary>
        /// A split button is displayed.
        /// </summary>
        ECF_HASSPLITBUTTON = 0x002,

        /// <summary>
        /// The label is hidden.
        /// </summary>
        ECF_HIDELABEL = 0x004,

        /// <summary>
        /// The command is a separator.
        /// </summary>
        ECF_ISSEPARATOR = 0x008,

        /// <summary>
        /// A UAC shield is displayed.
        /// </summary>
        ECF_HASLUASHIELD = 0x010,

        /// <summary>
        /// Introduced in Windows 7. The command is located in the menu immediately below a separator.
        /// </summary>
        ECF_SEPARATORBEFORE = 0x020,

        /// <summary>
        /// Introduced in Windows 7. The command is located in the menu immediately above a separator.
        /// </summary>
        ECF_SEPARATORAFTER = 0x040,

        /// <summary>
        /// Introduced in Windows 7. Selecting the command opens a drop-down submenu (for example, Include in library).
        /// </summary>
        ECF_ISDROPDOWN = 0x080,

        /// <summary>
        /// Introduced in Windows 8.
        /// </summary>
        ECF_TOGGLEABLE = 0x100,

        /// <summary>
        /// Introduced in Windows 8.
        /// </summary>
        ECF_AUTOMENUICONS = 0x200


    }
}
