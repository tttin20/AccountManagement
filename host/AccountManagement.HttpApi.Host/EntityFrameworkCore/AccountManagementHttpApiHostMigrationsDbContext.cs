using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AccountManagement.EntityFrameworkCore;

public class AccountManagementHttpApiHostMigrationsDbContext : AbpDbContext<AccountManagementHttpApiHostMigrationsDbContext>
{
    public AccountManagementHttpApiHostMigrationsDbContext(DbContextOptions<AccountManagementHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAccountManagement();
    }
}
