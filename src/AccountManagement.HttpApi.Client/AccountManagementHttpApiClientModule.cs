using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AccountManagement;

[DependsOn(
    typeof(AccountManagementApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class AccountManagementHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AccountManagementApplicationContractsModule).Assembly,
            AccountManagementRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AccountManagementHttpApiClientModule>();
        });

    }
}
