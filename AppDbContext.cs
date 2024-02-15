using Microsoft.EntityFrameworkCore;

using HotelApi.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Hotel> Hotel { get; set; }
    public DbSet<Media> Media { get; set; }
    public DbSet<Review> Review { get; set; }
}