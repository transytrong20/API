using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Bill
    {
        [ForeignKey("bill_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid PaymentId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid TransportId { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public DateTime DeliveryDate { get; set;}
        public StatusBill Status { get; set; }
        public string NickName { get; set; }  = string.Empty;
        public string Phone { get; set;} = string.Empty;
        public string email { get; set; } = string.Empty;
        public string? Note { get; set;}

        public virtual ICollection<InvoiceDetail> Invoices { get; set; }

        [ForeignKey("customer_id")]
        public Customer Customers { get; set; }
        [ForeignKey("payment_id")]
        public Payment Payments { get; set; }
        [ForeignKey("transport_id")]
        public Transport Transports { get; set; }
    }
}
