using HotelApi.Dto;

namespace HotelApi.Interfaces;

public interface IHotelService
{
	public IEnumerable<FeaturedHotelDto> GetFeaturedHotels();
	public IEnumerable<FeaturedHotelDto> GetPopularHotels();
}

