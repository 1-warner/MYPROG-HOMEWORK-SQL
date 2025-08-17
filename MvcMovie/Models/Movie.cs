using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 60 characters")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Release date is required")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(30, ErrorMessage = "Genre cannot be longer than 30 characters")]
        public string Genre { get; set; } = string.Empty;

        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
