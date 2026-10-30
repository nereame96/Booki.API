using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public required string Name { get; set; }

        public List<BookBriefDTO> Books { get; set; } = [];
    }
}
