using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace ZW.AttSvc.Mongo;

[DependsOn(
    typeof(MongoDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class MongoApplicationContractsModule : AbpModule
{

}
