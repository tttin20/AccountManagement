using AccountManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AccountManagement.Permissions;

public class AccountManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AccountManagementPermissions.GroupName, L("Permission:AccountManagement"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AccountManagementResource>(name);
    }
}
