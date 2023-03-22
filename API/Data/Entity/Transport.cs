using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Transport
    {
        [ForeignKey("transport_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string TransportName { get; set; }
        public StatusTransport Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
