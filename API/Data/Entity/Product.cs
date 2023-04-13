using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace API.Data.Entity
{
    [Table("Product")]
    public class Product //sản phẩm
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Image { get; set; } = string.Empty.ToString();
        [Required]
        public StatusProduct Status { get; set; }


        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }


        public Guid GroupId { get; set; }
        //[ForeignKey("group_id")]
        public Group Groups { get; set; }

        public Guid GoodsId { get; set; }
        //[ForeignKey("goods_id")]
        public Goods Goodss { get; set; }

    }
}
