using BlazorWardrobe.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using BlazorWardrobe.Infrastructure.Context;

namespace BlazorWardrobe.Infrastructure.Repositories
{
    public class GarmentRepository : IGarmentRepository
    {
        private readonly WardrobeDbContext context;
        public GarmentRepository(IDbContextFactory<WardrobeDbContext> factory) 
        {
            context = factory.CreateDbContext();
        }
    }
}
