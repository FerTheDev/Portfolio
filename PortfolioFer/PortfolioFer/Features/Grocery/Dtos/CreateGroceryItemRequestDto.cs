namespace PortfolioFer.Features.Grocery.Dtos
{
    public class CreateGroceryItemRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
