using Microsoft.EntityFrameworkCore;

namespace EFCoreDifferentDatabases.Entities
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext()
        {
            
        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
    }
}
