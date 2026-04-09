namespace PortfolioFer.Features.Projects.Dtos
{
    public class CreateProjectRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string GithubUrl { get; set; }
    }
}
