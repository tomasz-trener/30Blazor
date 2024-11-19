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

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteProduct([FromRoute] int id)
        {
            var result = await _productService.DeleteProductAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Product>>> CreateProduct([FromBody] Product newProduct)
        {
            var result = await _productService.CreateProductAsync(newProduct);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpGet("search/{text}/{page}/{pageSize}")]
        [HttpGet("search/{page}/{pageSize}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>>
           SearchProducts([FromRoute] string? text = null, [FromRoute] int page = 1, [FromRoute] int pageSize = 10)
        {
            var result = await _productService.SearchProductsAsync(text, page, pageSize);

            if (result.Success)
                return Ok(result);
            else
                return NotFound(result);
        }
        [HttpPost("filter")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> FilterProducts([FromBody] FilterParams filterParams, [FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var response = await _productService.FilterProductsAsync(filterParams, page, pageSize);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }
    }
}
