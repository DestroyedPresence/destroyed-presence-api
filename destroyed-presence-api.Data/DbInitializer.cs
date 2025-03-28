using destroyed.presence.Domain.Catalog;
using Emerald.Tiger.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Emerald.Tiger.Data
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