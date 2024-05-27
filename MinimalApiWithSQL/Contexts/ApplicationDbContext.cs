using Microsoft.EntityFrameworkCore;
using MinimalApiWithSQL.Entities;

namespace MinimalApiWithSQL.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
