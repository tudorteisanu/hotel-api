namespace HotelApi.Models;

public class Review
{
    public int Id { get; set; }
    public string Comment { get; set; } = "";
    public required float Value { get; set; }

    public Media[]? Gallery { get; set; }
    public User? Author { get; set;}
}

