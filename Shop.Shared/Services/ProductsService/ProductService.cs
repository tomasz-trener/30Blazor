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
    internal class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        public ProductService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
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
    }
}
