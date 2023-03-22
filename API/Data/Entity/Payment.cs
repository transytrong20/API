using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Payment
    {
        [ForeignKey("payment_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public StatusPayment Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
