using Microsoft.EntityFrameworkCore;

namespace _01_RestWithASPNETCore.Models.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }

        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
        }
            public DbSet<Person> Persons { get; set; }
    }
}
