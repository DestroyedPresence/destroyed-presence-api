using System;

namespace destroyed_presence_api.Domain.Catalog
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        
        public List<Rating>? Ratings { get; set; } = new List<Rating>();

        public void AddRating(Rating rating)
{
    this.Ratings.Add(rating);
}


        public Item(string name, string description, string brand, decimal price)
{
    if (string.IsNullOrEmpty(name))
    {
        throw new ArgumentNullException(name);
    }

    if (string.IsNullOrEmpty(description))
    {
        throw new ArgumentNullException(description);
    }

    if (string.IsNullOrEmpty(brand))
    {
        throw new ArgumentNullException(brand);
    }

    if(price < 0.00m)
    {
        throw new ArgumentException("Price must be greater than zero.");
    }

    Name = name;
    Description = description;
    Brand = brand;
    Price = price;
    this.Ratings = new List<Rating>();
}

    }
}
