using HotelApi.Enum;

namespace HotelApi.Dto;

public class FeaturedHotelDto
{
	public int Id { set; get; }
    public required string Name { set; get; }
    public string Location { set; get; } = "";
    public required string Price { set; get; }
    public float Rating { set; get; } = 0;

    public List<string> FoodTypes { set; get; } = new List<string> { };
    public required ImageWithUrlDto Image { get; set; }
   
}

