using Booki.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Booki.API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Author> Authors { get; set; }
    }
}
