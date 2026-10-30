using Booki.API.Entities;
using Booki.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public required string Title { get; set; }

        public int AuthorId { get; set; }

        public AuthorDTO? Author { get; set; }

        public int Pages { get; set; }

        public Genre Genre { get; set; }

        public ReadingStatus ReadingStatus { get; set; } = ReadingStatus.ToRead;

        [Range(1, 5)]
        public int? Rating { get; set; }

        [StringLength(300)]
        public string? Notes { get; set; } 
        public int UserId { get; set; }
        public UserDTO? User { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        //ISBN
        //CoverImageURL
    }
}
