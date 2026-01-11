using BlazorWardrobe.Domain.Entities;

namespace BlazorWardrobe.Application.Interfaces;

public interface IGarmentRepository
{
    Task AddAsync(Garment garment);
}
