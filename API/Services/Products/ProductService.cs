using API.Data;
using API.Data.Entity;
using API.DTO.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;
        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ActionResult<Product>> Create(ProductDto product)
        {
            var products = new Product()
            {
                ProductName = product.ProductName,
                Date = product.Date,
                Description = product.Description,
                Image = product.Image,
                Quantity = product.Quantity,
                Status = product.Status
            };
            await _dataContext.AddAsync(products);
            await _dataContext.SaveChangesAsync();
            return products;
        }

        public List<ProductDto> GetAll(string? search)
        {
            try
            {
                var products = _dataContext.Products.AsQueryable();

                if (!string.IsNullOrEmpty(search))
                {
                    products = products.Where(p => p.ProductName.Contains(search) );
                }
                
                var result = products.Select(p => new ProductDto
                {
                    ProductName = p.ProductName,
                    Date = p.Date,
                    Description = p.Description,
                    Quantity = p.Quantity,
                    Image = p.Image,
                    Status = p.Status
                });
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
