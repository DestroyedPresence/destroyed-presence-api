using destroyed_presence_api.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using destroyed_presence_api.Data;


namespace destroyed_presence_api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
                new Item("Shirt", "Ohio State shirt", "Nike", 29.99M)
                {
                    Id = 1
                },
                new Item("Shorts", "Ohio State shorts", "Nike", 44.99M)
                {
                    Id = 2
                }
            );
        }
    }
}