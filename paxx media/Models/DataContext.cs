using Microsoft.EntityFrameworkCore;

namespace paxx_media.Models
{
    public class DataContext : DbContext
    {
       // Constructor to pass options to the DbContext

        public DataContext(DbContextOptions<DataContext>options):base(options) { }

        // DbSet properties map models to tables in the database

        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

    }
}
