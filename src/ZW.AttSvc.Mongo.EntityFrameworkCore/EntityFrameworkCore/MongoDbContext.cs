using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ZW.AttSvc.Mongo.EntityFrameworkCore;

[ConnectionStringName(MongoDbProperties.ConnectionStringName)]
public class MongoDbContext : AbpDbContext<MongoDbContext>, IMongoDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public MongoDbContext(DbContextOptions<MongoDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureMongo();
    }
}
