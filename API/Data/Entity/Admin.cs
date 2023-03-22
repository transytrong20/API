using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Admin
    {
        [ForeignKey("admin_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UserAdmin { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } 
        public byte[] PasswordSalt { get; set; } 
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; } = DateTime.Now;
        public DateTime TokenExpires { get; set; } = new DateTime();
    }
}
