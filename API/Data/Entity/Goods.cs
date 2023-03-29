using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Goods
    {
        //các mặt hàng
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string GoodsName { get; set; }
        [Required]
        public string? Note { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
