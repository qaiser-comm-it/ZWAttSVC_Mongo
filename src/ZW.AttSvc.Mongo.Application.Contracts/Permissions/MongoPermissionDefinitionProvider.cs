using ZW.AttSvc.Mongo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ZW.AttSvc.Mongo.Permissions;

public class MongoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MongoPermissions.GroupName, L("Permission:Mongo"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MongoResource>(name);
    }
}
