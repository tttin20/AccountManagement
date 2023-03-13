using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AccountManagement.EntityFrameworkCore;

[ConnectionStringName(AccountManagementDbProperties.ConnectionStringName)]
public class AccountManagementDbContext : AbpDbContext<AccountManagementDbContext>, IAccountManagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public AccountManagementDbContext(DbContextOptions<AccountManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAccountManagement();
    }
}
