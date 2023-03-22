using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entity
{
    public class Group
    {
        [ForeignKey("group_id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string GroupName { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
