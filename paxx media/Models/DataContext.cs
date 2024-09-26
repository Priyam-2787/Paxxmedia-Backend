using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using paxx_media.Models;

namespace paxx_media.Models
{
    public class DataContext : DbContext
    {
        // Constructor to pass options to the DbContext

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // DbSet properties map models to tables in the database

        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=paxx media;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
           new User { ID = 1, Name = "Alice Smith", Email = "alice@example.com", PasswordHash = "hashedpassword1", Role = "Developer" },
           new User { ID = 2, Name = "Bob Johnson", Email = "bob@example.com", PasswordHash = "hashedpassword2", Role = "Data Analyst" },
           new User { ID = 3, Name = "Charlie Brown", Email = "charlie@example.com", PasswordHash = "hashedpassword3", Role = "scrum master" },
           new User { ID = 4, Name = "Ali Shah", Email = "ali@example.com", PasswordHash = "hashedpassword5", Role = "Developer" },
           new User { ID = 5, Name = "Bon Johnson", Email = "bon@example.com", PasswordHash = "hashedpassword9", Role = "Data Analyst" },
           new User { ID = 6, Name = "Juhi Brown", Email = "Juhi@example.com", PasswordHash = "hashedpassword7", Role = "scrum master" }


       );


        }






    }
}