using API.Helper.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    [Table("Bill")]
    public class Bill //hoá đơn
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime DeliveryDate { get; set;}
        [Required]
        public StatusBill Status { get; set; }
        [Required]
        public string NickName { get; set; }  = string.Empty;
        [Required]
        public string Phone { get; set;} = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string? Note { get; set;}

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }


        public Guid CustomerId { get; set; }
        //[ForeignKey("customer_id")]
        public Customer Customers { get; set; }

        public Guid PaymentId { get; set; }
        //[ForeignKey("payment_id")]
        public Payment Payments { get; set; }

        public Guid TransportId { get; set; }
        //[ForeignKey("transport_id")]
        public Transport Transports { get; set; }
    }
}
