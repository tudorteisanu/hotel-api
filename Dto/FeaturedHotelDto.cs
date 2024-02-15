using System;
using HotelApi.Models;

namespace HotelApi.Dto;
public class FeaturedHotelDto
{
	public int Id { set; get; }
    public required string Name { set; get; }
    public string Location { set; get; } = "";
    public required string Price { set; get; }
    public required float Rating { set; get; }

    public List<string> FoodTypes { set; get; } = new List<string> { };
    public required ImageWithUrlDto Image { get; set; }
   
}

