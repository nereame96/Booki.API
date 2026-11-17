using Booki.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Booki.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public BooksController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<BookDTO>> Get()
        {
            return await context.Books
                .Select(b => new BookDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorId = b.AuthorId,
                    AuthorName = b.Author!.Name,
                    Pages = b.Pages,
                    Genre = b.Genre,
                    ReadingStatus = b.ReadingStatus,
                    Rating = b.Rating,
                    Notes = b.Notes,
                    StartDate = b.StartDate,
                    FinishDate = b.FinishDate
                })
                .ToListAsync();
        }

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<BookDTO>> Get(int id)
        //{

        //}

    }
}
