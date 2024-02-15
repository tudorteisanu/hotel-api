using AutoMapper;
using HotelApi.Dto;

using HotelApi.Models;
using HotelApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Services;

public class HotelService : IHotelService
{
    private readonly IMapper mapper;
    private readonly AppDbContext dbContext;

    public HotelService(IMapper _mapper, AppDbContext _dbContext)
    {
        mapper = _mapper;
        dbContext = _dbContext;
    }

	public IEnumerable<FeaturedHotelDto> GetFeaturedHotels()
	{
        IEnumerable<Hotel> hotels = dbContext.Hotel
           .Include(m => m.Reviews)
           .Include(m => m.Image)
           .Where(hotel => hotel.Featured == true)
           .OrderBy(hotel => hotel.Id)
           .Take(4);
       
        return mapper.Map<IEnumerable<Hotel>, IEnumerable<FeaturedHotelDto>>(hotels);
    }

    public IEnumerable<FeaturedHotelDto> GetPopularHotels()
    {
        IEnumerable<Hotel> hotels = dbContext.Hotel
            .Include(m => m.Reviews)
            .Include(m => m.Image)
            .Where(hotel => hotel.Featured == true)
            .Take(4);
        return mapper.Map<IEnumerable<Hotel>, IEnumerable<FeaturedHotelDto>>(hotels);
    }

    public IEnumerable<Hotel> GetHotelsList()
    {

        return dbContext.Hotel.Include(m => m.Image).AsEnumerable();
    }

    public Hotel AddHotel(CreateHotelDto hotelDto)
    {
        var hotel = mapper.Map<CreateHotelDto, Hotel>(hotelDto);
        dbContext.Hotel.Add(hotel);
        dbContext.SaveChanges();
        return hotel;
    }

    public Hotel? UpdateHotel(int hotelId, UpdateHotelDto payload)
    {
        var hotelFromDb = dbContext.Hotel.Single(c => c.Id == hotelId);

        if (hotelFromDb == null)
        {

            return null;
        }

        if (payload.ImageId != 0)
        {
            hotelFromDb.ImageId = payload.ImageId;
        }

        dbContext.SaveChanges();

        return hotelFromDb;
    }
}

