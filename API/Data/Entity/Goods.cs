using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Goods //các mặt hàng
    {
        //các mặt hàng
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string GoodsName { get; set; } =string.Empty;
        [Required]
        public string? Note { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
