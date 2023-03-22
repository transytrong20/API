using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Product
    {
        [ForeignKey("product_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid GroupId { get; set; }
        public Guid GoodsId { get; set; }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public string Image { get; set; }
        public StatusProduct Status { get; set; }


        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }


        [ForeignKey("group_id")]
        public Group Groups { get; set; }
        [ForeignKey("goods_id")]
        public Goods Goodss { get; set; }

    }
}
