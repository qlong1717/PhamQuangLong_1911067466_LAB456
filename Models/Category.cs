using System.ComponentModel.DataAnnotations;

namespace PhamQuangLong_1911067466_LAB456.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}