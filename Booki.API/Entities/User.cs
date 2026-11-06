using System.ComponentModel.DataAnnotations;

namespace Booki.API.Entities
{
    public class User
    {
        public int Id {  get; set; }

        [Required]
        [StringLength(150)]
        public required string Name { get; set; }

        [Required]
        [StringLength(30)]
        public required string Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(250)]
        public required string Email { get; set; }

        public List<Book>? Books { get; set; }

    }
}
