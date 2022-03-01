using ZW.AttSvc.Mongo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ZW.AttSvc.Mongo;

public abstract class MongoController : AbpControllerBase
{
    protected MongoController()
    {
        LocalizationResource = typeof(MongoResource);
    }
}
