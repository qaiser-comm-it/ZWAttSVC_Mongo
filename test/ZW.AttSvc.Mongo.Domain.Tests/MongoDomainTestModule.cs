using ZW.AttSvc.Mongo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ZW.AttSvc.Mongo;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(MongoEntityFrameworkCoreTestModule)
    )]
public class MongoDomainTestModule : AbpModule
{

}
