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

        public async Task<ServiceResponse<Product>> CreateProductAsync(Product newProduct)
        {
            var result = new ServiceResponse<Product>();
            try
            {
                await _context.Products.AddAsync(newProduct);
                await _context.SaveChangesAsync();

                result.Data = newProduct;
                result.Success = true;
                result.Message = "Product created successfully";
            }
            catch (Exception ex)
            {
                result.Message = $"Error creating product: {ex.Message}";
                result.Success = false;
            }
            return result;
        }

        public Task<ServiceResponse<bool>> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Product>> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var result = new ServiceResponse<List<Product>>();
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

        public Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct)
        {
            throw new NotImplementedException();
        }
    }
}
