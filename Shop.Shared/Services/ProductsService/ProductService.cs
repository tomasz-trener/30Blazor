using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Services.ProductsService
{
    internal class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        public Task<ServiceReponse<List<Product>>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
