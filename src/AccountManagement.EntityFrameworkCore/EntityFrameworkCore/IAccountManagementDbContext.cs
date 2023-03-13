using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AccountManagement.EntityFrameworkCore;

[ConnectionStringName(AccountManagementDbProperties.ConnectionStringName)]
public interface IAccountManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
