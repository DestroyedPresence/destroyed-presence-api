using Microsoft.EntityFrameworkCore;
using destroyed.presence.Domain.Catalog;
using Emerald.Tiger.Data;


namespace destroyed_presence_api.Data;

public class StoreContext:DbContext
{


    public StoreContext(DbContextOptions<StoreContext> options)
    :base(options)
    {}
    public DbSet<Item> Items {get;set;}

    public DbSet<Order> orders { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        DbInitializer.Initialize(builder);
    }
}
