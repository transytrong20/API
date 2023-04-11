using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class Table
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } =string.Empty;
        [Required]
        public string Type { get; set; } = string.Empty;
        [Required] 
        public string TypeDescription { get; set; } = string.Empty;
        //[Required]
        //public string TypeName { get; set; }
        //[Required]
        //public string TypeDescriptionDescription { get; set; }
        //[Required]
        //public string TypeNameDescription { get; set; }
    }
}

