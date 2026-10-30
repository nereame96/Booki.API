using Booki.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(250)]
        public required string Email { get; set; }

        public List<BookBriefDTO>? Books { get; set; }
    }
}
