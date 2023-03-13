using Volo.Abp;
using Volo.Abp.MongoDB;

namespace AccountManagement.MongoDB;

public static class AccountManagementMongoDbContextExtensions
{
    public static void ConfigureAccountManagement(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
