using API.DTO.Products;
using API.Services.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Product
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)

        {
            _productService = productService;
        }



        [HttpPost("SearchProduct")]
        public IActionResult SearchProducts(string? search, double? from, double? to)
        {
            var result = _productService.Search(search, from, to);
            return Ok(result);
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(ProductDto product)
        {
            var result = _productService.Create(product);
            return Ok(result);
        }



    }
}
