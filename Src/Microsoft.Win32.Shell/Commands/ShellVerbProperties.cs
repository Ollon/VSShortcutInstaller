namespace Microsoft.Win32.Shell
{
    public class ShellVerbProperties : IShellVerbProperties
    {
        public static ShellVerbProperties From(RegistryKey key)
        {
            ShellVerbProperties properties = new ShellVerbProperties
            {
                CanonicalName = key.GetValue("CanonicalName", string.Empty),
                Description = key.GetValue("Description", string.Empty),
                Icon = key.GetValue("Icon", string.Empty),
                MUIVerb = key.GetValue("MUIVerb", string.Empty),
                CommandStateSync = key.GetValue("CommandStateSync", string.Empty),
                ExplorerCommandHandler = key.GetValue("ExplorerCommandHandler", string.Empty),
                CommandStateHandler = key.GetValue("CommandStateHandler", string.Empty),
                FolderHandler = key.GetValue("FolderHandler", string.Empty),
                VerbHandler = key.GetValue("VerbHandler", string.Empty),
                VerbName = key.GetValue("VerbName", string.Empty),
                ImpliedSelectionModel = key.GetValue("ImpliedSelectionModel", string.Empty),
                ResolveLinksQueryBehavior = key.GetValue("ResolveLinksQueryBehavior", string.Empty),
                VerbList = key.GetValue("VerbList", string.Empty),
                ActionId = key.GetValue("ActionId", string.Empty),
                CommandStore = key.GetValue("CommandStore", string.Empty),
                InvokeCommandOnSelection = key.GetValue("InvokeCommandOnSelection", string.Empty),
                StaticVerbOnly = key.GetValue("StaticVerbOnly", string.Empty),
                ControlPanelName = key.GetValue("ControlPanelName", string.Empty),
                ResolveLinksInvokeBehavior = key.GetValue("ResolveLinksInvokeBehavior", string.Empty),
                IsInContextMenu = key.GetValue("IsInContextMenu", string.Empty),
                AttributeMask = key.GetValue("AttributeMask", string.Empty),
                AttributeValue = key.GetValue("AttributeValue", string.Empty),
                ShowAsDisabledIfHidden = key.GetValue("ShowAsDisabledIfHidden", string.Empty),
                DescriptionTitle = key.GetValue("DescriptionTitle", string.Empty),
                SendToVerb = key.GetValue("SendToVerb", string.Empty),
                CommandFlags = key.GetValue("CommandFlags", string.Empty),
                SubCommands = key.GetValue("SubCommands", string.Empty),
                ExplorerHost = key.GetValue("ExplorerHost", string.Empty),
                LaunchExplorerFlags = key.GetValue("LaunchExplorerFlags", string.Empty),
                DoNotElevate = key.GetValue("DoNotElevate", string.Empty),
                PaneID = key.GetValue("PaneID", string.Empty),
                PaneVisibleProperty = key.GetValue("PaneVisibleProperty", string.Empty),
                AppliesTo = key.GetValue("AppliesTo", string.Empty),
                Class = key.GetValue("Class", string.Empty),
                DefaultAppliesTo = key.GetValue("DefaultAppliesTo", string.Empty),
                MultiSelectModel = key.GetValue("MultiSelectModel", string.Empty),
                Property = key.GetValue("Property", string.Empty),
                Position = key.GetValue("Position", string.Empty),
                PlayMusicMode = key.GetValue("PlayMusicMode", string.Empty),
                Title = key.GetValue("Title", string.Empty),
                WalkFlags = key.GetValue("WalkFlags", string.Empty),
                PositionCompare = key.GetValue("PositionCompare", string.Empty),
                PolicyID = key.GetValue("PolicyID", string.Empty),
                RemoveDeviceHandler = key.GetValue("RemoveDeviceHandler", string.Empty),
                EnableIfContextMenuVerbExists = key.GetValue("EnableIfContextMenuVerbExists", string.Empty),
                MediaTypeFlags = key.GetValue("MediaTypeFlags", string.Empty),
                VerbToInvoke = key.GetValue("VerbToInvoke", string.Empty),
                ExtendedSubCommandsKey = key.GetValue("ExtendedSubCommandsKey", string.Empty)
            };
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
