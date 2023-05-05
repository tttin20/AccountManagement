using AccountManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AccountManagement.Blazor.Server.Host;

public abstract class AccountManagementComponentBase : AbpComponentBase
{
    protected AccountManagementComponentBase()
    {
        LocalizationResource = typeof(AccountManagementResource);
    }
}
