using Booki.API.Entities;
using Booki.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class CreateBookDTO
    {
        [Required]
        [StringLength(150, MinimumLength = 2)]
        public required string Title { get; set; }

        public int AuthorId { get; set; }

        public int? Pages { get; set; }

        public Genre? Genre { get; set; }

        public ReadingStatus ReadingStatus { get; set; } = ReadingStatus.ToRead;

        [Range(1, 5)]
        public int? Rating { get; set; }

        [StringLength(300)]
        public string? Notes { get; set; }
        public int UserId { get; set; }

    }
}
