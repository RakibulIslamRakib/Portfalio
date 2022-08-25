using Microsoft.EntityFrameworkCore;
using Portfalio.Models;

namespace Portfalio.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Project { get; set; }
    }
}
