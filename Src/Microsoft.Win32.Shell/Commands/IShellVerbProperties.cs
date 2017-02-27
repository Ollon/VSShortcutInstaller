namespace Microsoft.Win32.Shell
{
    public interface IShellVerbProperties
    {
        object ActionId { get; }
        object AppliesTo { get; }
        object AttributeMask { get; }
        object AttributeValue { get; }
        object CanonicalName { get; }
        object Class { get; }
        object CommandFlags { get; }
        object CommandStateHandler { get; }
        object CommandStateSync { get; }
        object CommandStore { get; }
        object ControlPanelName { get; }
        object DefaultAppliesTo { get; }
        object Description { get; }
        object DescriptionTitle { get; }
        object DoNotElevate { get; }
        object EnableIfContextMenuVerbExists { get; }
        object ExplorerCommandHandler { get; }
        object ExplorerHost { get; }
        object ExtendedSubCommandsKey { get; }
        object FolderHandler { get; }
        object Icon { get; }
        object ImpliedSelectionModel { get; }
        object InvokeCommandOnSelection { get; }
        object IsInContextMenu { get; }
        object LaunchExplorerFlags { get; }
        object MediaTypeFlags { get; }
        object MUIVerb { get; }
        object MultiSelectModel { get; }
        object PaneID { get; }
        object PaneVisibleProperty { get; }
        object PlayMusicMode { get; }
        object PolicyID { get; }
        object Position { get; }
        object PositionCompare { get; }
        object Property { get; }
        object RemoveDeviceHandler { get; }
        object ResolveLinksInvokeBehavior { get; }
        object ResolveLinksQueryBehavior { get; }
        object SendToVerb { get; }
        object ShowAsDisabledIfHidden { get; }
        object StaticVerbOnly { get; }
        object SubCommands { get; }
        object Title { get; }
        object VerbHandler { get; }
        object VerbList { get; }
        object VerbName { get; }
        object VerbToInvoke { get; }
        object WalkFlags { get; }
    }
}