using Localization.Resources.AbpUi;
using AccountManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace AccountManagement;

[DependsOn(
    typeof(AccountManagementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class AccountManagementHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AccountManagementHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AccountManagementResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
