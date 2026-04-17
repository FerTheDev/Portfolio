using PortfolioFer.Features.Grocery.Dtos;

namespace PortfolioFer.Features.Grocery.Services
{
    public interface IGroceryService
    {
        Task<List<GroceryItemResponseDto>> GetAll();
        Task<GroceryItemResponseDto?> GetById(Guid id);
        Task<GroceryItemResponseDto> Create(CreateGroceryItemRequestDto request);
        Task<GroceryItemResponseDto?> Update(Guid id, UpdateGroceryItemRequestDto request);
        Task<bool> Delete(Guid id);
        Task<GroceryItemResponseDto?> ToggleComplete(Guid id);
    }
}