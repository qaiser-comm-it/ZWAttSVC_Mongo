using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ZW.AttSvc.Mongo;

[DependsOn(
    typeof(MongoApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class MongoHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(MongoApplicationContractsModule).Assembly,
            MongoRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<MongoHttpApiClientModule>();
        });

    }
}
