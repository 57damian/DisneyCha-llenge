using DisneyChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace DisneyChallenge.Contexts
{
    public class DisneyContext : DbContext
    {
        private const string Schema = "Disney";

        public DisneyContext(DbContextOptions<DisneyContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);

            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Accion",
                image = "Prueba"
            },
            new Category
            {
                Id=2,   
                Name ="Aventura",
                image = "Prueba2"
            }
            );

            modelBuilder.Entity<Category>().Property(X => X.Name).HasMaxLength(20);
        }

        public DbSet<Category> categories { get; set; } = null!;

        public DbSet<Movie> movies { get; set; } = null!;

        public DbSet<Character> characters { get; set; } = null!;

    }
}
