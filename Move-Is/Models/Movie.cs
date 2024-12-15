using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Move_Is.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Range(1900, 2100)]
        public string Country { get; set; }

        [Required]
        [StringLength(500)]
        public string Synopsis { get; set; }

        [Range(0, 10)]
        public double Rating { get; set; }

        public string ImageUrl { get; set; }
        
    }
}
