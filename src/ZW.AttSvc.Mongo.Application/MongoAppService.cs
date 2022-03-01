using ZW.AttSvc.Mongo.Localization;
using Volo.Abp.Application.Services;

namespace ZW.AttSvc.Mongo;

public abstract class MongoAppService : ApplicationService
{
    protected MongoAppService()
    {
        LocalizationResource = typeof(MongoResource);
        ObjectMapperContext = typeof(MongoApplicationModule);
    }
}
