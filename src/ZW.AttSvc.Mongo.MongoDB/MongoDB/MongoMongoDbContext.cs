using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ZW.AttSvc.Mongo.MongoDB;

[ConnectionStringName(MongoDbProperties.ConnectionStringName)]
public class MongoMongoDbContext : AbpMongoDbContext, IMongoMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureMongo();
    }
}
