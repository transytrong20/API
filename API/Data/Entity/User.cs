//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Net.Sockets;


//namespace API.Data.Entity
//{
//    public class User
//    {
//        [Key]
//        public Guid Id { get; set; } = Guid.NewGuid();
//        public string Username { get; set; } = string.Empty;
//        public byte[] PasswordHash { get; set; }
//        public byte[] PasswordSalt { get; set; }
//        public string RefreshToken { get; set; } = string.Empty;
//        public DateTime TokenCreated { get; set; }
//        public DateTime TokenExpires { get; set; }



//        public virtual ICollection<Customer> Customers { get; set; }
//        //[ForeignKey("customer_id")]
//        //public Customer Customers { get; set; }
//    }
//}
