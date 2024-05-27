using Microsoft.EntityFrameworkCore;
using MinimalApiWithSQL.Entities;

namespace MinimalApiWithSQL.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        //In PM manager -> Add-Migration PeopleTable
        //In PM manager -> Update-Database
        public DbSet<Person> People { get; set; }
    }
}
