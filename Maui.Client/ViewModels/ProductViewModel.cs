using CommunityToolkit.Mvvm.ComponentModel;
using Shop.Shared;
using Shop.Shared.Services.ProductsService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.Client.ViewModels
{
    //CommunityToolkit.Mvvm
    public partial class ProductViewModel : ObservableObject
    {
        private readonly IProductService _productService;

        [ObservableProperty]
        private ObservableCollection<Product> _products;

        public ProductViewModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task LoadProducts()
        {
            var result = await _productService.GetProductsAsync();
            if (result.Success)
            {
                Products = new ObservableCollection<Product>(result.Data);
            }
        }

    }
}
