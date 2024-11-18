using Bogus;
using Shop.Shared;

namespace Shop.DataSeeder
{
    public class ProductDataSeeder
    {
        public static List<Product> GenerateProductsData()
        {
            var productsFaker = new Faker<Product>()
                .RuleFor(p => p.Title, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.Price, f => f.Random.Double(1, 1000))
                .RuleFor(p => p.Barcode, f => f.Commerce.Ean13())
                .RuleFor(p => p.ReleaseDate, f => f.Date.Past());

            return productsFaker.Generate(100);
        }
    }
}
