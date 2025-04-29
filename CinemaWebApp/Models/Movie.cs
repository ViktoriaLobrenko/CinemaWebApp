using System.ComponentModel.DataAnnotations;

namespace CinemaWebApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public int Duration { get; set; } // хвилини

        [Required]
        public int ReleaseYear { get; set; }

        public string AgeLimit { get; set; }

        public string Description { get; set; }
    }
}
