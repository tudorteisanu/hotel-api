using Microsoft.AspNetCore.Mvc;
using HotelApi.Models;
using AutoMapper;
using HotelApi.Dto;
using HotelApi.Services;

namespace HotelApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HotelController : ControllerBase
{
    private HotelService hotelService;

    public HotelController(IMapper mapper)
    {
        hotelService = new HotelService(mapper);
    }

    [HttpGet("[action]")]
    public IEnumerable<FeaturedHotelDto> GetFeaturedHotels()
    {
        return hotelService.GetFeaturedHotels();
    }

    [HttpGet("[action]")]
    public IEnumerable<FeaturedHotelDto> GetPopularHotels()
    {
        return hotelService.GetPopularHotels();
    }


    [HttpGet]
    public IEnumerable<Hotel> GetHotels()
    {
        return hotelService.GetHotelsList();
    }


    [HttpPost]
    public Hotel Post(Hotel hotel)
    {
        return hotel;
    }


    [HttpPut("{hotelId}")]
    public Hotel Put(int hotelId, Hotel hotel)
    {

        return new Hotel
        {
            Id = hotelId,
            Name = hotel.Name,
            Image = new Media { Path = "images/image_1", Id = 1 }
        };
    }
}

