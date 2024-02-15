using System;
namespace HotelApi.Models;

public class Food
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public required int Price { set; get; }

	public required FoodCatergory Catergory { get; set; }
	public required Media Image { get; set; }
}