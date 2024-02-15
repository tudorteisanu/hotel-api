using HotelApi.Dto;
using HotelApi.Models;

namespace HotelApi.Interfaces;

public interface IHotelService
{
	public IEnumerable<FeaturedHotelDto> GetFeaturedHotels();
	public IEnumerable<FeaturedHotelDto> GetPopularHotels();
	public IEnumerable<Hotel> GetHotelsList();
	public Hotel AddHotel(CreateHotelDto hotel);
	public Hotel? UpdateHotel(int hotelId, UpdateHotelDto payload);
}

