using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace API.Data.Entity
{
    public class Transport //vậnn chuyển
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string TransportName { get; set; }
        [Required]
        public StatusTransport Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
