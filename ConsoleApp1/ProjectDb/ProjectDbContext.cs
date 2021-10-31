using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectDb.Model;
using System.IO;

namespace ProjectDb
{
    public class ProjectDbContext : DbContext
    {
            public DbSet<Book> Books { get; set; }
            public DbSet<Person> People { get; set; }
            public DbSet<Rating> Ratings { get; set; }
            public DbSet<Writer> Writers { get; set; }
            //public DbSet<Genre> Genres { get; set; }
            public DbSet<AudioBook> AudioBooks { get; set; }
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Recording> Recordings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);

        }         
    }
}
