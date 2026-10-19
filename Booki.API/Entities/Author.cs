using Booki.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace Booki.API.Entities
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public required string Name { get; set; }

        public List<Book>? Books { get; set; }

        public List<Genre>? Genre { get; set; }
    }
}
