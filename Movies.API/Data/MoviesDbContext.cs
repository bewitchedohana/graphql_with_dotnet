using Microsoft.EntityFrameworkCore;
using Movies.API.Models;

namespace Movies.API.Data;

public class MoviesDbContext(DbContextOptions<MoviesDbContext> options)
    : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieReview> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>()
            .Property(m => m.Genre)
            .HasConversion<string>();


        base.OnModelCreating(modelBuilder);
    }
}
