using BlazorWardrobe.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWardrobe.Infrastructure.Context;

public class WardrobeDbContext : DbContext
{
    public WardrobeDbContext(DbContextOptions<WardrobeDbContext> options) : base(options)
    {
    }

    public DbSet<Garment> Garments { get; set; }
}
