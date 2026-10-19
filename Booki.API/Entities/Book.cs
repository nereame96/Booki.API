using Booki.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace Booki.API.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public required string Title { get; set; }

        public int AuhorId { get; set; }

        public Author? Author { get; set; }

        public int Pages { get; set; }

        public Genre? Genre { get; set; }

        public ReadingStatus? ReadingStatus { get; set; } //habrá que poner que por defecto ToRead

        [Range(1, 5)]
        public int Rating { get; set; }

        [StringLength(300)]
        public string? Notes { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        //ISBN
        //CoverImageURL
    }
}
