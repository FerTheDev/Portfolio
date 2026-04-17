namespace PortfolioFer.Features.Grocery.Dtos
{
    public class GroceryItemResponseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}
}