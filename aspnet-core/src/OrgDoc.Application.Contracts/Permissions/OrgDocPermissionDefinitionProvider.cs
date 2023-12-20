using OrgDoc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OrgDoc.Permissions;

public class OrgDocPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OrgDocPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OrgDocPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OrgDocResource>(name);
    }
}
