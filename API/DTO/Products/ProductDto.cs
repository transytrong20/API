using API.Helper.Enum;

namespace API.DTO.Products
{
    public class ProductDto
    {
        //public Guid Id { get; set; }
        //public Guid GroupId { get; set; }
        //public Guid GoodsId { get; set; }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public string Image { get; set; }
        public StatusProduct Status { get; set; }

        public Guid GruopId { get; set; }
        public Guid GoodsId { get; set; }
    }
}
