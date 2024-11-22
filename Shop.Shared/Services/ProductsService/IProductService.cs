﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Services.ProductsService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> CreateProductAsync(Product newProduct);

        Task<ServiceResponse<bool>> DeleteProductAsync(int id);

        Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct);

        Task<ServiceResponse<Product>> GetProductAsync(int id);


        Task<ServiceResponse<List<Product>>> SearchProductsAsync(string text, int page, int pageSize);  
        Task<ServiceResponse<List<Product>>> FilterProductsAsync(FilterParams filterParams, int page, int pageSize);


    }
}
