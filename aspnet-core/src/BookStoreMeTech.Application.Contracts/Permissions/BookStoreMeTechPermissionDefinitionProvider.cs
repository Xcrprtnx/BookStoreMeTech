using BookStoreMeTech.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BookStoreMeTech.Permissions;

public class BookStoreMeTechPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStoreMeTechPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStoreMeTechPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreMeTechResource>(name);
    }
}
