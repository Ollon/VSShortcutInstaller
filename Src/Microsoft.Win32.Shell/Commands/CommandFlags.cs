namespace Microsoft.Win32.Shell.Commands
{
    public enum CommandFlags
    {
        Default = EXPCMDFLAGS.ECF_DEFAULT,
        HasSubCommands = EXPCMDFLAGS.ECF_HASSUBCOMMANDS,
        HasSplitButton = EXPCMDFLAGS.ECF_HASSPLITBUTTON,
        HideLabel = EXPCMDFLAGS.ECF_HIDELABEL,
        IsSeparator = EXPCMDFLAGS.ECF_ISSEPARATOR,
        HasLUAShield = EXPCMDFLAGS.ECF_HASLUASHIELD,
        SeparatorBefore = EXPCMDFLAGS.ECF_SEPARATORBEFORE,
        SeparatorAfter = EXPCMDFLAGS.ECF_SEPARATORAFTER,
        IsDropDown = EXPCMDFLAGS.ECF_ISDROPDOWN,
        Toggleable = EXPCMDFLAGS.ECF_TOGGLEABLE,
        AutoMenuIcons = EXPCMDFLAGS.ECF_AUTOMENUICONS

    }
}
