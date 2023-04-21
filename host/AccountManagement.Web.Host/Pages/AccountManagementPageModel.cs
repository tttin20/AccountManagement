using AccountManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AccountManagement.Pages;

public abstract class AccountManagementPageModel : AbpPageModel
{
    protected AccountManagementPageModel()
    {
        LocalizationResourceType = typeof(AccountManagementResource);
    }
}
