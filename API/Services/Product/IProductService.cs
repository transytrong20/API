using API.DTO.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Product
{
    public interface IProductService
    {
        //public IActionResult CreateProduct(ProductDto product);
        public IActionResult GrtList();
    }
}
