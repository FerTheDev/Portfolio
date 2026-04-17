using PortfolioFer.Database.Entities;
using PortfolioFer.Features.Grocery.Dtos;
using PortfolioFer.Features.Grocery.Repositories;

namespace PortfolioFer.Features.Grocery.Services
{
    public class GroceryService : IGroceryService
    {
        private readonly IGroceryRepository _repository;

        public GroceryService(IGroceryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GroceryItemResponseDto>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<GroceryItemResponseDto?> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task<GroceryItemResponseDto> Create(CreateGroceryItemRequestDto request)
        {
            var item = new GroceryItem
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                IsCompleted = false
            };

            await _repository.Create(item);

            return new GroceryItemResponseDto
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                IsCompleted = item.IsCompleted
            };
        }

        public async Task<GroceryItemResponseDto?> Update(Guid id, UpdateGroceryItemRequestDto request)
        {
            var item = new GroceryItem
            {
                Name = request.Name,
                Description = request.Description
            };

            return await _repository.Update(id, item);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.Delete(id);
        }

        public async Task<GroceryItemResponseDto?> ToggleComplete(Guid id)
        {
            return await _repository.ToggleComplete(id);
        }
    }
}