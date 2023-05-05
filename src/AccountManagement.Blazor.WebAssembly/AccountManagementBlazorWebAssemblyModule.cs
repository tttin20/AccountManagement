using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace AccountManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(AccountManagementBlazorModule),
    typeof(AccountManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class AccountManagementBlazorWebAssemblyModule : AbpModule
{

}
