using AccountManagement.Localization;
using Volo.Abp.Application.Services;

namespace AccountManagement;

public abstract class AccountManagementAppService : ApplicationService
{
    protected AccountManagementAppService()
    {
        LocalizationResource = typeof(AccountManagementResource);
        ObjectMapperContext = typeof(AccountManagementApplicationModule);
    }
}
