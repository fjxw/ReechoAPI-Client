using Domain.Enums;

namespace Domain.Entities;

public class Vynil
{
    public int Id { get; set; } 
    public string Title { get; set; } = string.Empty;
    public Genre Genre { get; set; } = Genre.None;
    public string Artist { get; set; } = string.Empty;
    public string Image { get; set; } = "vynil.jpg";
    public decimal Price { get; set; } = 0;
    public int Quantity { get; set; } = 0;
}