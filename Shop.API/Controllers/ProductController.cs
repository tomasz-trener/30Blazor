using Microsoft.AspNetCore.Mvc;
using Shop.Shared.Services.ProductsService;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

    }
}
