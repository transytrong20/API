using API.Data.Entity;
using API.DTO.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Products
{
    public interface IProductService
    {
        public List<ProductDto> GetAll(string? search);
        public Task<ActionResult<Product>> Create(ProductDto product);
    }
}
