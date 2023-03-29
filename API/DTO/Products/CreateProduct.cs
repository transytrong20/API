using API.Helper.Enum;

namespace API.DTO.Products
{
    public class CreateProduct
    {
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public string Image { get; set; }
        public StatusProduct Status { get; set; }
    }
}
