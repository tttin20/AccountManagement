using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace AccountManagement.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(AccountManagementBlazorModule)
    )]
public class AccountManagementBlazorServerModule : AbpModule
{

}
