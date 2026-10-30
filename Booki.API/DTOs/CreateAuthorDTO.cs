using System.ComponentModel.DataAnnotations;

namespace Booki.API.DTOs
{
    public class CreateAuthorDTO
    {
        [Required]
        [StringLength(150, MinimumLength = 2)]
        public required string Name { get; set; }

    }
}
