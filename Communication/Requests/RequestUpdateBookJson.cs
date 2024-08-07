namespace LivrariaApi.Communication.Requests;

public class RequestUpdateBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genre { get; set; }
    public decimal Price { get; set; }
}
