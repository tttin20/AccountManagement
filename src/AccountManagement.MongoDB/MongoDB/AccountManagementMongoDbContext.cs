using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AccountManagement.MongoDB;

[ConnectionStringName(AccountManagementDbProperties.ConnectionStringName)]
public class AccountManagementMongoDbContext : AbpMongoDbContext, IAccountManagementMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureAccountManagement();
    }
}
