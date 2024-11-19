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

        public async Task<ServiceResponse<List<Product>>> FilterProductsAsync(FilterParams filterParams, int page, int pageSize)
        {
            var filteredProducts = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(filterParams.Id))
                filteredProducts = filteredProducts.Where(p => p.Id.ToString().Contains(filterParams.Id));
            if (!string.IsNullOrEmpty(filterParams.Title))
                filteredProducts = filteredProducts.Where(p => p.Title.Contains(filterParams.Title));
            if (!string.IsNullOrEmpty(filterParams.Price))
                filteredProducts = filteredProducts.Where(p => p.Price.ToString().Contains(filterParams.Price));
            if (!string.IsNullOrEmpty(filterParams.Barcode))
                filteredProducts = filteredProducts.Where(p => p.Barcode.Contains(filterParams.Barcode));


            var paginatedProducts = filteredProducts
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            if (!string.IsNullOrEmpty(filterParams.ReleaseDate))
                paginatedProducts = paginatedProducts.Where(p => p.ReleaseDate.ToShortDateString().Contains(filterParams.ReleaseDate)).ToList();

            return new ServiceResponse<List<Product>>
            {
                Data = paginatedProducts,
                Success = true
            };
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

        public async Task<ServiceResponse<List<Product>>> SearchProductsAsync(string text, int page, int pageSize)
        {
            IQueryable<Product> query = _context.Products;

            if (!string.IsNullOrEmpty(text))
            {
                query = query.Where(p => p.Title.Contains(text) || p.Description.Contains(text));
            }

            try
            {
                var products = await query
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var result = new ServiceResponse<List<Product>>
                {
                    Data = products,
                    Success = true,
                    Message = "Products retrieved successfully"
                };
                return result;
            }
            catch (Exception)
            {
                var result = new ServiceResponse<List<Product>>
                {
                    Data = null,
                    Success = false,
                    Message = "Error retrieving products"
                };
                return result;
            }
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
            catch (Exception ex )
            {
                result.Message = $"Error updating product: {ex.Message}";
                result.Success = false;
                return result;
            }
          
        }
    }
}
