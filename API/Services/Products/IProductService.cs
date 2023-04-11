using API.Data.Entity;
using API.DTO.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Products
{
    public interface IProductService
    {
        public List<ProductDto> Search(string? search, double? from, double? to);
        public Task<ActionResult<Product>> Create(ProductDto product);
    }
}
