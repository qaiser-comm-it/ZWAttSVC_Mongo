namespace ZW.AttSvc.Mongo;

public static class MongoDbProperties
{
    public static string DbTablePrefix { get; set; } = "Mongo";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Mongo";
}
