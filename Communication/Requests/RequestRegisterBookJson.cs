namespace LivrariaApi.Controllers;

public class RequestRegisterBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genre { get; set; } 
    public decimal Price { get; set; } 
    public int StockQuantity { get; set; } 
}

