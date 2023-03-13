using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AccountManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AccountManagementDomainSharedModule)
)]
public class AccountManagementDomainModule : AbpModule
{

}
