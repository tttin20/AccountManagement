using AccountManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AccountManagement;

public abstract class AccountManagementController : AbpControllerBase
{
    protected AccountManagementController()
    {
        LocalizationResource = typeof(AccountManagementResource);
    }
}
