using API.Data;
using API.DTO.Products;
using API.Services.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Product
{
    [Authorize]
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
        public async Task<IActionResult> GetProduct()
        {
            var result = _productService.GrtList();
            return Ok(result);
        }



        //[HttpPost]
        //public async IActionResult CreateProduct(ProductDto product)
        //{
        //    var result = await _productService.CreateProduct(product);
        //    return result;
        //}
    }
}
