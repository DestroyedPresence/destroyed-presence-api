using Microsoft.EntityFrameworkCore;
using destroyed.presence.Domain.Catalog;


namespace destroyed_presence_api.Data;

public class StoreContext:DbContext
{


    public StoreContext(DbContextOptions<StoreContext> options)
    :base(options)
    {}
    public DbSet<Item> Items {get;set;}
}
