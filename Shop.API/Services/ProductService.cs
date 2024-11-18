using Microsoft.EntityFrameworkCore;
using Shop.API.Models;
using Shop.Shared;
using Shop.Shared.Services.ProductsService;

namespace Shop.API.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceReponse<List<Product>>> GetProductsAsync()
        {
            var result = new ServiceReponse<List<Product>>();
            try
            {
                result.Data = await _context.Products.ToListAsync();
                result.Success = true;
                result.Message = "Products retrieved successfully";
            }
            catch (Exception ex)
            {
                result.Message = $"Error retrieving products: {ex.Message}";
                result.Success = false;
            }
            return result;
        }
    }
}
