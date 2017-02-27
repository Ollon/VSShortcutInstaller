namespace Microsoft.Win32.Shell
{
    public class ShellVerbProperties : IShellVerbProperties
    {
        public static ShellVerbProperties From(RegistryKey key)
        {
            ShellVerbProperties properties = new ShellVerbProperties();
            properties.CanonicalName = key.GetValue("CanonicalName", string.Empty);
            properties.Description = key.GetValue("Description", string.Empty);
            properties.Icon = key.GetValue("Icon", string.Empty);
            properties.MUIVerb = key.GetValue("MUIVerb", string.Empty);
            properties.CommandStateSync = key.GetValue("CommandStateSync", string.Empty);
            properties.ExplorerCommandHandler = key.GetValue("ExplorerCommandHandler", string.Empty);
            properties.CommandStateHandler = key.GetValue("CommandStateHandler", string.Empty);
            properties.FolderHandler = key.GetValue("FolderHandler", string.Empty);
            properties.VerbHandler = key.GetValue("VerbHandler", string.Empty);
            properties.VerbName = key.GetValue("VerbName", string.Empty);
            properties.ImpliedSelectionModel = key.GetValue("ImpliedSelectionModel", string.Empty);
            properties.ResolveLinksQueryBehavior = key.GetValue("ResolveLinksQueryBehavior", string.Empty);
            properties.VerbList = key.GetValue("VerbList", string.Empty);
            properties.ActionId = key.GetValue("ActionId", string.Empty);
            properties.CommandStore = key.GetValue("CommandStore", string.Empty);
            properties.InvokeCommandOnSelection = key.GetValue("InvokeCommandOnSelection", string.Empty);
            properties.StaticVerbOnly = key.GetValue("StaticVerbOnly", string.Empty);
            properties.ControlPanelName = key.GetValue("ControlPanelName", string.Empty);
            properties.ResolveLinksInvokeBehavior = key.GetValue("ResolveLinksInvokeBehavior", string.Empty);
            properties.IsInContextMenu = key.GetValue("IsInContextMenu", string.Empty);
            properties.AttributeMask = key.GetValue("AttributeMask", string.Empty);
            properties.AttributeValue = key.GetValue("AttributeValue", string.Empty);
            properties.ShowAsDisabledIfHidden = key.GetValue("ShowAsDisabledIfHidden", string.Empty);
            properties.DescriptionTitle = key.GetValue("DescriptionTitle", string.Empty);
            properties.SendToVerb = key.GetValue("SendToVerb", string.Empty);
            properties.CommandFlags = key.GetValue("CommandFlags", string.Empty);
            properties.SubCommands = key.GetValue("SubCommands", string.Empty);
            properties.ExplorerHost = key.GetValue("ExplorerHost", string.Empty);
            properties.LaunchExplorerFlags = key.GetValue("LaunchExplorerFlags", string.Empty);
            properties.DoNotElevate = key.GetValue("DoNotElevate", string.Empty);
            properties.PaneID = key.GetValue("PaneID", string.Empty);
            properties.PaneVisibleProperty = key.GetValue("PaneVisibleProperty", string.Empty);
            properties.AppliesTo = key.GetValue("AppliesTo", string.Empty);
            properties.Class = key.GetValue("Class", string.Empty);
            properties.DefaultAppliesTo = key.GetValue("DefaultAppliesTo", string.Empty);
            properties.MultiSelectModel = key.GetValue("MultiSelectModel", string.Empty);
            properties.Property = key.GetValue("Property", string.Empty);
            properties.Position = key.GetValue("Position", string.Empty);
            properties.PlayMusicMode = key.GetValue("PlayMusicMode", string.Empty);
            properties.Title = key.GetValue("Title", string.Empty);
            properties.WalkFlags = key.GetValue("WalkFlags", string.Empty);
            properties.PositionCompare = key.GetValue("PositionCompare", string.Empty);
            properties.PolicyID = key.GetValue("PolicyID", string.Empty);
            properties.RemoveDeviceHandler = key.GetValue("RemoveDeviceHandler", string.Empty);
            properties.EnableIfContextMenuVerbExists = key.GetValue("EnableIfContextMenuVerbExists", string.Empty);
            properties.MediaTypeFlags = key.GetValue("MediaTypeFlags", string.Empty);
            properties.VerbToInvoke = key.GetValue("VerbToInvoke", string.Empty);
            properties.ExtendedSubCommandsKey = key.GetValue("ExtendedSubCommandsKey", string.Empty);
            return properties;

        }

        private ShellVerbProperties()
        {

        }
        public object CanonicalName { get; private set; }
        public object Description { get; private set; }
        public object Icon { get; private set; }
        public object MUIVerb { get; private set; }
        public object CommandStateSync { get; private set; }
        public object ExplorerCommandHandler { get; private set; }
        public object CommandStateHandler { get; private set; }
        public object FolderHandler { get; private set; }
        public object VerbHandler { get; private set; }
        public object VerbName { get; private set; }
        public object ImpliedSelectionModel { get; private set; }
        public object ResolveLinksQueryBehavior { get; private set; }
        public object VerbList { get; private set; }
        public object ActionId { get; private set; }
        public object CommandStore { get; private set; }
        public object InvokeCommandOnSelection { get; private set; }
        public object StaticVerbOnly { get; private set; }
        public object ControlPanelName { get; private set; }
        public object ResolveLinksInvokeBehavior { get; private set; }
        public object IsInContextMenu { get; private set; }
        public object AttributeMask { get; private set; }
        public object AttributeValue { get; private set; }
        public object ShowAsDisabledIfHidden { get; private set; }
        public object DescriptionTitle { get; private set; }
        public object SendToVerb { get; private set; }
        public object CommandFlags { get; private set; }
        public object SubCommands { get; private set; }
        public object ExplorerHost { get; private set; }
        public object LaunchExplorerFlags { get; private set; }
        public object DoNotElevate { get; private set; }
        public object PaneID { get; private set; }
        public object PaneVisibleProperty { get; private set; }
        public object AppliesTo { get; private set; }
        public object Class { get; private set; }
        public object DefaultAppliesTo { get; private set; }
        public object MultiSelectModel { get; private set; }
        public object Property { get; private set; }
        public object Position { get; private set; }
        public object PlayMusicMode { get; private set; }
        public object Title { get; private set; }
        public object WalkFlags { get; private set; }
        public object PositionCompare { get; private set; }
        public object PolicyID { get; private set; }
        public object RemoveDeviceHandler { get; private set; }
        public object EnableIfContextMenuVerbExists { get; private set; }
        public object MediaTypeFlags { get; private set; }
        public object VerbToInvoke { get; private set; }
        public object ExtendedSubCommandsKey { get; private set; }

    }
}
