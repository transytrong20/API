using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class FeedBack
    {
        [ForeignKey("feedback_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public DateTime ResponseDate { get; set; } = DateTime.Now;
        public string? ResponseHeaders { get; set; }
        public string FeedbackContent { get; set; } = string.Empty;
        public string? ReplyToFeedback { get; set; }
        public StatusFeedBack Status { get; set; }


        [ForeignKey("customer_id")]
        public Customer CustomerCustomer { get; set; }
    }
}
