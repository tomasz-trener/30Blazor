using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Shop.Shared.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Shared.Services.ProductsService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        public ProductService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<ServiceResponse<Product>> CreateProductAsync(Product newProduct)
        {
            var response = await _httpClient.PostAsJsonAsync(_appSettings.ProductEndpoint.CreateProduct, newProduct);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Product>>();
            return result;
        }

        public async Task<ServiceResponse<bool>> DeleteProductAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
            return result;


        }

        public Task<ServiceResponse<List<Product>>> FilterProductsAsync(FilterParams filterParams, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Product>>();
            return result;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(_appSettings.ProductEndpoint.GetProducts);
                response.EnsureSuccessStatusCode();
                var josn = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<ServiceResponse<List<Product>>>(josn);
                return products;
            }
            catch (HttpRequestException ex)
            {
                return new ServiceResponse<List<Product>> { Success = false, Message = "Failed to load products:" + ex.Message };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<Product>> { Success = false, Message = ex.Message };
            }

        }

        public Task<ServiceResponse<List<Product>>> SearchProductsAsync(string text, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync(_appSettings.ProductEndpoint.UpdateProduct, updatedProduct);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var product = JsonConvert.DeserializeObject<ServiceResponse<Product>>(json);
                return product;

            }
            catch (HttpRequestException ex)
            {
                return new ServiceResponse<Product> { Success = false, Message = "Failed to load product:" + ex.Message };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Product> { Success = false, Message = ex.Message };
            }
        }
    }
}
