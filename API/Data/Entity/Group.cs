using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Group
    {
        //nhóm hàng
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string GroupName { get; set; }
        [Required]
        public string? Note { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
