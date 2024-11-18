using Microsoft.AspNetCore.Mvc;
using Shop.Shared;
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


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var response = await _productService.GetProductsAsync();
            if (response.Success)
            {
               return Ok(response);
            }
            return NotFound(response);
        }
    }
}
