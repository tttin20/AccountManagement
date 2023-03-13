using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AccountManagement.MongoDB;

[ConnectionStringName(AccountManagementDbProperties.ConnectionStringName)]
public interface IAccountManagementMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
