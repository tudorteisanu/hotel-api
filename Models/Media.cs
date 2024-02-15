namespace HotelApi.Models;

public class Media
{
    public int Id { get; set; }
    public required string Path { get; set; }
    public required string Type { get; set; }
    public required long Size { get; set; }

    public string GetUrl()
    {
        return $"https://localhost:7260/{this.Path}";
    }
}

