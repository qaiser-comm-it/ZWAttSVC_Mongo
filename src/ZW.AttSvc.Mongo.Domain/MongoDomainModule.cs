using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ZW.AttSvc.Mongo;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(MongoDomainSharedModule)
)]
public class MongoDomainModule : AbpModule
{

}
