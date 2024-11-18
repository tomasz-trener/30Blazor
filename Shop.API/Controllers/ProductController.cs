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

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct([FromRoute] int id)
        {
            var response = await _productService.GetProductAsync(id);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Product>>> UpdateProduct([FromBody] Product updatedProduct)
        {
            var response = await _productService.UpdateProductAsync(updatedProduct);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }
    }
}
