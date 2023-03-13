using Volo.Abp.Modularity;

namespace AccountManagement;

[DependsOn(
    typeof(AccountManagementApplicationModule),
    typeof(AccountManagementDomainTestModule)
    )]
public class AccountManagementApplicationTestModule : AbpModule
{

}
