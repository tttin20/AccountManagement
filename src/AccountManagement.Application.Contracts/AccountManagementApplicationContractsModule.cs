using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace AccountManagement;

[DependsOn(
    typeof(AccountManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class AccountManagementApplicationContractsModule : AbpModule
{

}
