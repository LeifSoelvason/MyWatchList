using System.ComponentModel.DataAnnotations;

namespace MyWatchList.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

    }
}
