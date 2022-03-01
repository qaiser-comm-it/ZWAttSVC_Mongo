using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ZW.AttSvc.Mongo.MongoDB;

[ConnectionStringName(MongoDbProperties.ConnectionStringName)]
public interface IMongoMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
