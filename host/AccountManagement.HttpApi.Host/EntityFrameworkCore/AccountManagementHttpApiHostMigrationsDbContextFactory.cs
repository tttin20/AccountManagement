using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AccountManagement.EntityFrameworkCore;

public class AccountManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AccountManagementHttpApiHostMigrationsDbContext>
{
    public AccountManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AccountManagementHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AccountManagement"));

        return new AccountManagementHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
