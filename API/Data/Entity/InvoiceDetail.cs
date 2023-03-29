 using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace API.Data.Entity
{
    public class InvoiceDetail
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        //[Required]
        //public Guid BillId { get; set; }
        //[Required]
        //public Guid PruductId { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public double Amount { get; set; }

        [ForeignKey("bill_id")]
        public Bill Bills { get; set; } 
        [ForeignKey("product_id")]
        public Product Pruducts { get; set; }

    }
}
