using HotelApi.Enum;
namespace HotelApi.Models;


public class Hotel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string Location { get; set; } = "";
    public string Price { get; set; } = "";
    public bool Featured { get; set; }

    public Media[]? Gallery { get; set; }
    public WorkTime? WorkTime { get; set; }
    public required Media Image { get; set; }
    public List<string> FoodTypes { set; get; } = new List<string> { };
    public List<Review> Reviews { get; set; } = new List<Review> { };
}

