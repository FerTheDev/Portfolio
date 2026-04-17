using Microsoft.EntityFrameworkCore;
using PortfolioFer.Database.Context;
using PortfolioFer.Database.Entities;
using PortfolioFer.Features.Grocery.Dtos;

namespace PortfolioFer.Features.Grocery.Repositories
{
    public class GroceryRepository : IGroceryRepository
    {
        private readonly AppDbContext _context;

        public GroceryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GroceryItemResponseDto>> GetAll()
        {
            return await _context.GroceryItems
                .Select(g => new GroceryItemResponseDto
                {
                    Id = g.Id,
                    Name = g.Name,
                    Description = g.Description,
                    IsCompleted = g.IsCompleted
                })
                .ToListAsync();
        }

        public async Task<GroceryItemResponseDto?> GetById(Guid id)
        {
            var item = await _context.GroceryItems.FindAsync(id);

            if (item == null) return null;

            return new GroceryItemResponseDto
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                IsCompleted = item.IsCompleted
            };
        }

        public async Task Create(GroceryItem item)
        {
            await _context.GroceryItems.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Delete(Guid id)
        {
            var item = await _context.GroceryItems.FindAsync(id);

            if (item == null) return false;

            _context.GroceryItems.Remove(item);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<GroceryItemResponseDto?> Update(Guid id, GroceryItem updatedItem)
        {
            var item = await _context.GroceryItems.FindAsync(id);

            if (item == null) return null;

            item.Name = updatedItem.Name;
            item.Description = updatedItem.Description;

            await _context.SaveChangesAsync();

            return new GroceryItemResponseDto
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                IsCompleted = item.IsCompleted
            };
        }

        public async Task<GroceryItemResponseDto?> ToggleComplete(Guid id)
        {
            var item = await _context.GroceryItems.FindAsync(id);

            if (item == null) return null;

            item.IsCompleted = !item.IsCompleted;

            await _context.SaveChangesAsync();

            return new GroceryItemResponseDto
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                IsCompleted = item.IsCompleted
            };
        }
    }
}