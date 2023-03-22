using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Goods
    {
        [ForeignKey("goods_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string GoodsName { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
