using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class CreateUserDTO
    {
        [Required]
        [StringLength(150, MinimumLength = 2)]
        public required string Name { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public required string Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(250)]
        public required string Email { get; set; }
    }
}
