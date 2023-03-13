using AccountManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AccountManagement;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(AccountManagementEntityFrameworkCoreTestModule)
    )]
public class AccountManagementDomainTestModule : AbpModule
{

}
