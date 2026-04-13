using PortfolioFer.Features.Profile.Dtos;

namespace PortfolioFer.Features.Profile.Repositories
{
    public interface IProfileRepository
    {
        Task<ProfileResponseDto> Get();
    }
}
