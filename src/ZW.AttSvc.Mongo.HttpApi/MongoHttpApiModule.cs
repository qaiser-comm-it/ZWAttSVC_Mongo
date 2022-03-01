using Localization.Resources.AbpUi;
using ZW.AttSvc.Mongo.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ZW.AttSvc.Mongo;

[DependsOn(
    typeof(MongoApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class MongoHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(MongoHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<MongoResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
