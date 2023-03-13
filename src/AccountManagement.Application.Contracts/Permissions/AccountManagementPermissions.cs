using Volo.Abp.Reflection;

namespace AccountManagement.Permissions;

public class AccountManagementPermissions
{
    public const string GroupName = "AccountManagement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AccountManagementPermissions));
    }
}
