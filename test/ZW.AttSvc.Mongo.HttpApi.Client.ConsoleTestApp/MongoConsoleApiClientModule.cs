using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ZW.AttSvc.Mongo;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MongoHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class MongoConsoleApiClientModule : AbpModule
{

}
