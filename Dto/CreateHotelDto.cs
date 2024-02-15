using HotelApi.Enum;

namespace HotelApi.Dto;

public class CreateHotelDto
{
    public required string Name { set; get; }
    public string Location { set; get; } = "";
    public required string Price { set; get; }
    public bool Featured { set; get; } = false;

    public List<FoodTypes> FoodTypes { set; get; } = new List<FoodTypes> { };
}

