using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Customer
    {
        [ForeignKey("customer_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public Status Status { get; set; }


        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }

        [ForeignKey("User")]
        public User Users { get; set; }

    }
}
