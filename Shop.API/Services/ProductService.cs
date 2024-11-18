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

        public async Task<ServiceResponse<bool>> DeleteProductAsync(int id)
        {
            var result = new ServiceResponse<bool>();
            
            try
            {
                Product product = _context.Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    _context.Products.Remove(product);
                    await _context.SaveChangesAsync();

                    result.Data = true;
                    result.Success = true;
                    result.Message = "Product deleted successfully";
                }
              
            }
            catch (Exception ex)
            {
                result.Message = $"Error deleting product: {ex.Message}";
                result.Success = false;
            }
            return result;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int id)
        {
            var result = new ServiceResponse<Product>();
            try
            {
                result.Data = await _context.Products.FirstAsync(p => p.Id == id);
                result.Success = true;
                result.Message = "Product retrieved successfully";
            }
            catch (Exception ex)
            {
                result.Message = $"Error retrieving product: {ex.Message}";
                result.Success = false;
            }
            return result;
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

        public async Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct)
        {
            var result = new ServiceResponse<Product>();

            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == updatedProduct.Id);
                if (product == null)
                {
                    result.Success = false;
                    result.Message = "Product not found";
                    return result;
                }
                _context.Entry(product).CurrentValues.SetValues(updatedProduct);

                //product.Title = updatedProduct.Title;
                //product.Description = updatedProduct.Description;
                //product.Price = updatedProduct.Price;
                //product.Barcode= updatedProduct.Barcode;
                //product.ReleaseDate = updatedProduct.ReleaseDate;

                await _context.SaveChangesAsync();
                result.Success = true;
                result.Data = product;
                result.Message = "Product updated successfully";
                return result;

            }
            catch (Exception)
            {

                throw;
            }
          
        }
    }
}
