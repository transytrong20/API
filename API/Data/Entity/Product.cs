using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace API.Data.Entity
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        //[Required]
        //public Guid GroupId { get; set; }
        //[Required]
        //public Guid GoodsId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public StatusProduct Status { get; set; }


        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }


        [ForeignKey("group_id")]
        public Group Groups { get; set; }
        [ForeignKey("goods_id")]
        public Goods Goodss { get; set; }

    }
}
