using PortfolioFer.Database.Entities;
using PortfolioFer.Features.Grocery.Dtos;

namespace PortfolioFer.Features.Grocery.Repositories
{
    public interface IGroceryRepository
    {
        Task<List<GroceryItemResponseDto>> GetAll();
        Task<GroceryItemResponseDto?> GetById(Guid id);
        Task Create(GroceryItem item);
        Task<GroceryItemResponseDto?> Update(Guid id, GroceryItem item);
        Task<bool> Delete(Guid id);
        Task<GroceryItemResponseDto?> ToggleComplete(Guid id);
    }
}