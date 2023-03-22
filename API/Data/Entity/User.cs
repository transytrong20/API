using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace API.Data.Entity
{
    public class User
    {
        [ForeignKey("user_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }



        public virtual ICollection<Customer> Tickets { get; set; }
        //[ForeignKey("customer_id")]
        //public Customer Customers { get; set; }
    }
}
