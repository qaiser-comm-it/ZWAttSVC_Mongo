using Volo.Abp.Modularity;

namespace ZW.AttSvc.Mongo;

[DependsOn(
    typeof(MongoApplicationModule),
    typeof(MongoDomainTestModule)
    )]
public class MongoApplicationTestModule : AbpModule
{

}
