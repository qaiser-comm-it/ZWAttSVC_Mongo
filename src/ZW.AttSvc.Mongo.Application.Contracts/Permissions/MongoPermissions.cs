using Volo.Abp.Reflection;

namespace ZW.AttSvc.Mongo.Permissions;

public class MongoPermissions
{
    public const string GroupName = "Mongo";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(MongoPermissions));
    }
}
