using Booki.API.Entities;
using Booki.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Booki.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AuthorsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<AuthorDTO>> Get()
        {
            return await context.Authors
                .Select(a => new AuthorDTO 
                { 
                    Id = a.Id,
                    Name = a.Name,
                    Books = a.Books!
                    .Select(b => new BookBriefDTO 
                    {
                        Id = b.Id, 
                        Title = b.Title, 
                        Pages = b.Pages, 
                        Genre = b.Genre
                    }).ToList(),
                }).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Author>> Get(int id)
        {
            var author = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);

            if (author == null)
            {
                return NotFound();
            }

            return author;
        }

        [HttpPost]

        public async Task<ActionResult> Post(CreateAuthorDTO createAuthorDto)
        {
            var author = new Author
            {
                Name = createAuthorDto.Name
            };

            context.Add(author);
            await context.SaveChangesAsync();
            return Ok();
        }


    }
}
