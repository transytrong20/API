using API.Data;
using API.DTO.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;
        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult GrtList()
        {
            var result = _dataContext.Products.ToList();
            return null;
        }

        





        //public IActionResult CreateProduct(ProductDto product)
        //{
        //    //var products = new ProductDto();
        //    var create = _dataContext.Products.AsNoTracking();
        //    {

        //    }
        //}
    }
}
