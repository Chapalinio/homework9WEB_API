using homework9WEB_API.Models;
using Microsoft.EntityFrameworkCore;

namespace lesson9WEB_API.Context;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<Review> Reviews { get; set; }
}