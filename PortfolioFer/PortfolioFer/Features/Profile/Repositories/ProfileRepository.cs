using PortfolioFer.Features.Profile.Dtos;

namespace PortfolioFer.Features.Profile.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        public Task<ProfileResponseDto> Get()
        {
            var profile = new ProfileResponseDto
            {
                Name = "Fernanda",
                Role = "Backend Developer em formação",
                Description = "Estudando C#, .NET e construção de APIs com boas práticas."
            };

            return Task.FromResult(profile);
        }
    }
}
