using Microsoft.EntityFrameworkCore;

namespace MyWatchList.Models
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}

