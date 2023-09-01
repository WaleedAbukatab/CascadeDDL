using CascadeDDL.Models;
using Microsoft.EntityFrameworkCore;

namespace CascadeDDL.context
{
    public class CascadeDbContext : DbContext
    {
        public CascadeDbContext(DbContextOptions<CascadeDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
