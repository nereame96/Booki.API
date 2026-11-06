using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class UpdateAuthorDTO
    {
        [Required]
        [StringLength(150, MinimumLength = 2)]
        public required string Name { get; set; }

    }
}
