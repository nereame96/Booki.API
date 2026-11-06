using Booki.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class UpdateBookDTO
    {
        [Required]
        [StringLength(150, MinimumLength = 2)]
        public required string Title { get; set; }

        [Range(1, int.MaxValue)]
        public int AuthorId { get; set; }

        public int? Pages { get; set; }

        public Genre? Genre { get; set; }

        public ReadingStatus ReadingStatus { get; set; } = ReadingStatus.ToRead;

        [Range(1, 5)]
        public int? Rating { get; set; }

        [StringLength(300)]
        public string? Notes { get; set; }
        public DateTime? StartDate { get; set; }  // TODO crear validation para que startdate no sea despues que finishdate
        public DateTime? FinishDate { get; set; }
    }
}
