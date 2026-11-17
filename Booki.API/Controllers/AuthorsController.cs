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
        public async Task<ActionResult<AuthorDTO>> Get(int id)
        {
            var author = await context.Authors
                .Where(a => a.Id == id)
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
                    }).ToList()
                }).FirstOrDefaultAsync();
                

            if (author is null)
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

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, UpdateAuthorDTO updateAuthorDTO)
        {
            var author = await context.Authors.FirstOrDefaultAsync(a => a.Id == id);

            if (author is null)
            {
                return NotFound();
            }

            author.Name = updateAuthorDTO.Name;

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var hasBooks = await context.Books.AnyAsync(b => b.AuthorId == id);

            if (hasBooks)
            {
                return Conflict("The author has books and cannot be deleted.");
            }

            var authorDeleted = await context.Authors.Where(a => a.Id == id).ExecuteDeleteAsync();

            if (authorDeleted == 0)
            {
                return NotFound();
            }

            return NoContent();
        }


    }
}
