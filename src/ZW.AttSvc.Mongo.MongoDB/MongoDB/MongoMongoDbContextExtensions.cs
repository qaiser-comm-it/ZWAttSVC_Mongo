using Volo.Abp;
using Volo.Abp.MongoDB;

namespace ZW.AttSvc.Mongo.MongoDB;

public static class MongoMongoDbContextExtensions
{
    public static void ConfigureMongo(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
