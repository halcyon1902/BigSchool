using System.ComponentModel.DataAnnotations;

namespace Big_School.Models
{
    public class Category
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(225)]
        public string Name { get; set; }
    }
}