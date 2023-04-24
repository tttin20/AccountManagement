using AccountManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AccountManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AccountManagementPageModel : AbpPageModel
{
    protected AccountManagementPageModel()
    {
        LocalizationResourceType = typeof(AccountManagementResource);
        ObjectMapperContext = typeof(AccountManagementWebModule);
    }
}
