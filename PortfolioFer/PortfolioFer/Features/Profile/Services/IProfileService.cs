using PortfolioFer.Features.Profile.Dtos;

namespace PortfolioFer.Features.Profile.Services
{
    public interface IProfileService
    {
        Task<ProfileResponseDto> Get();
    }
}