using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Admin
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string UserAdmin { get; set; } = string.Empty;
        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        [Required]
        public string RefreshToken { get; set; } = string.Empty;
        [Required]
        public DateTime TokenCreated { get; set; } = DateTime.Now;
        [Required]
        public DateTime TokenExpires { get; set; } = new DateTime();
    }
}
