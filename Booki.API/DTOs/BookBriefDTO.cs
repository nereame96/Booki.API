using Booki.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class BookBriefDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public required string Title { get; set; }

        public int Pages { get; set; }

        public Genre Genre { get; set; }
    }
}
