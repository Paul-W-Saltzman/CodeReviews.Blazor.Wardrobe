using BlazorWardrobe.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using BlazorWardrobe.Infrastructure.Context;
using BlazorWardrobe.Domain.Entities;

namespace BlazorWardrobe.Infrastructure.Repositories
{
    public class GarmentRepository : IGarmentRepository
    {
        private readonly WardrobeDbContext context;
        public GarmentRepository(IDbContextFactory<WardrobeDbContext> factory) 
        {
            context = factory.CreateDbContext();
        }

        public Task AddAsync(Garment garment)
        {
            throw new NotImplementedException();
        }
    }
}
