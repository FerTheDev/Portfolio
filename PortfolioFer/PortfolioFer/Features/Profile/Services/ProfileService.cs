using PortfolioFer.Features.Profile.Dtos;
using PortfolioFer.Features.Profile.Repositories;

namespace PortfolioFer.Features.Profile.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _repository;

        public ProfileService(IProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProfileResponseDto> Get()
        {
            return await _repository.Get();
        }
    }
}
