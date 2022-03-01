using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ZW.AttSvc.Mongo.EntityFrameworkCore;

[ConnectionStringName(MongoDbProperties.ConnectionStringName)]
public interface IMongoDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
