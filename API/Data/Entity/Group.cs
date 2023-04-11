using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Group //nhóm sản phẩm
    {
        //nhóm hàng
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string GroupName { get; set; } = string.Empty;
        [Required]
        public string? Note { get; set; } = null;

        public virtual ICollection<Product> Products { get; set; }

    }
}
