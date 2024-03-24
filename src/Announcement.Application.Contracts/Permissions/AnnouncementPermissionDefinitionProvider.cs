using Announcement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Announcement.Permissions;

public class AnnouncementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AnnouncementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AnnouncementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AnnouncementResource>(name);
    }
}
