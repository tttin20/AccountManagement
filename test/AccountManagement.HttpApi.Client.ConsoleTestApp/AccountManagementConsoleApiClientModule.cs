using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AccountManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AccountManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AccountManagementConsoleApiClientModule : AbpModule
{

}
