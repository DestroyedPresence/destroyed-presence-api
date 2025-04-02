using Microsoft.EntityFrameworkCore;
using destroyed_presence_api.Domain.Catalog;
using destroyed.presence.Domain.Orders;

using destroyed_presence_api.Data;


namespace destroyed_presence_api.Data;

public class StoreContext:DbContext
{


    public StoreContext(DbContextOptions<StoreContext> options)
    :base(options)
    {}
    public DbSet<Item> Items {get;set;}

    public DbSet<Orders> Orders { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        DbInitializer.Initialize(builder);
    }
}
