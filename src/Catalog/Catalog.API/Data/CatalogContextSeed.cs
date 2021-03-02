using System.Collections.Generic;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone X",
                    Summary = "This is iphone",
                    Description = "Lorem ipsum dolor",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart phone"
                },
                new Product()
                {
                    Name = "Samsung S8",
                    Summary = "This is samsung",
                    Description = "Lorem ipsum dolor",
                    ImageFile = "product-2.png",
                    Price = 950.00M,
                    Category = "Smart phone"
                },
                new Product()
                {
                    Name = "Asus rog phone",
                    Summary = "This is asus",
                    Description = "Lorem ipsum dolor",
                    ImageFile = "product-3.png",
                    Price = 990.00M,
                    Category = "Smart phone"
                },
                new Product()
                {
                    Name = "Xiaomi",
                    Summary = "This is xiaomi",
                    Description = "Lorem ipsum dolor",
                    ImageFile = "product-4.png",
                    Price = 600.00M,
                    Category = "Smart phone"
                }
            };
        }
    }
}