 using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class InvoiceDetail
    {
        [ForeignKey("invoicedetail_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid BillId { get; set; }
        public Guid PruductId { get; set; }
        public double Quantity { get; set; }
        public double Amount { get; set; }

        [ForeignKey("bill_id")]
        public Bill Bills { get; set; } 
        [ForeignKey("product_id")]
        public Product Pruducts { get; set; }

    }
}
