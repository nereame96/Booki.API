using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class CreateUserDTO
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(250)]
        public required string Email { get; set; }
    }
}
