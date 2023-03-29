using API.Helper.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class FeedBack
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        //[Required]
        //public Guid CustomerId { get; set; }
        [Required]
        public DateTime ResponseDate { get; set; } = DateTime.Now;
        [Required]
        public string? ResponseHeaders { get; set; }
        [Required]
        public string FeedbackContent { get; set; } = string.Empty;
        [Required]
        public string? ReplyToFeedback { get; set; }
        [Required]
        public StatusFeedBack Status { get; set; }


        [ForeignKey("customer_id")]
        public Customer CustomerCustomer { get; set; }
    }
}
