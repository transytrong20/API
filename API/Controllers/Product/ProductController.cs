using API.DTO.Products;
using API.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Product
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)

        {
            _productService = productService;
        }



        [HttpPost("GetAllProduct")]
        public IActionResult GetAllProducts(string? search)
        {
            try
            {
                var result = _productService.GetAll(search);
                return Ok(result);
            }
            catch
            {
                return BadRequest("...");
            }
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(ProductDto product)
        {
            try
            {
                var result = _productService.Create(product);
                return Ok(result);
            }
            catch
            {
                return BadRequest("...");
            }
        }
    }
}
