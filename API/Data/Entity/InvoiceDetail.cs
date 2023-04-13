 using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace API.Data.Entity
{
    [Table("InvoiceDetail")]
    public class InvoiceDetail // chi tiết hoá đơn
    { 
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public double Quantity { get; set; }
        [Required]
        public double Price { get; set; }


        //[ForeignKey("Bill")]
        public Guid BillId { get; set; }
        public Bill Bills { get; set; }

        //[ForeignKey("product_id")]
        public Guid ProductId { get; set; }
        public Product Pruducts { get; set; }

    }
}
