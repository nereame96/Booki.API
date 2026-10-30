using System.ComponentModel.DataAnnotations;

namespace Booki.API.Entities
{
    public class User
    {
        public int Id {  get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(250)]
        public required string Email { get; set; }

        public List<Book>? Books { get; set; }

    }
}
