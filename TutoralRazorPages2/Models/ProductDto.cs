using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TutoralRazorPages2.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; } = "";

        [Required, MaxLength(100, ErrorMessage ="Poop")]
        public string Brand { get; set; } = "";

        [Required, MaxLength(100)]
        public string Category { get; set; } = "";

        [Required]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        public IFormFile? ImageFile { get; set; }
    }
}
