using API.Helper.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace API.Data.Entity
{
    public class Payment //thanh toán
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; }
        [Required]
        public StatusPayment Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
