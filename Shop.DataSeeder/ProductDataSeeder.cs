using Bogus;
using Shop.Shared;

namespace Shop.DataSeeder
{
    public class ProductDataSeeder
    {
        public static List<Product> GenerateProductsData()
        {
            var productsFaker = new Faker<Product>()
                .UseSeed(123456)
                .RuleFor(p=>p.Id, f=>f.IndexFaker+1) //  dodac +1 zeby zaczynalo sie od 1
                .RuleFor(p => p.Title, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.Price, f => f.Random.Double(1, 1000))
                .RuleFor(p => p.Barcode, f => f.Commerce.Ean13())
                .RuleFor(p => p.ReleaseDate, f => new DateTime(2024,1,1)); // bug w fakerze, nie uwzglednia seeda

            return productsFaker.Generate(100);
        }
    }
}
