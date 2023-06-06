using System.ComponentModel.DataAnnotations;

namespace KARAOKEAPIWEB.Models
{
    public class MenuModel
    {
        [Key]   
        public int IdMenu { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public int Price { get; set; } 
    }

}
