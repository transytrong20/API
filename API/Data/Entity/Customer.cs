using API.Helper.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();


        [Required]
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }


        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public Status Status { get; set; }


        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        //[ForeignKey("User")]
        //public User Users { get; set; }
        
    }
}
