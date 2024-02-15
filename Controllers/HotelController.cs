using Microsoft.AspNetCore.Mvc;
using HotelApi.Models;
using AutoMapper;
using HotelApi.Dto;
using HotelApi.Services;
using HotelApi.Interfaces;

namespace HotelApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HotelController : ControllerBase
{
    private IHotelService hotelService;

    public HotelController(IHotelService _hotelService)
    {
        hotelService = _hotelService;
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
    public Hotel Post(CreateHotelDto hotel)
    {
        return hotelService.AddHotel(hotel);
    }

    [HttpPatch("{hotelId}")]
    public Hotel? UpdateHotel(int hotelId, UpdateHotelDto payload)
    {
        return hotelService.UpdateHotel(hotelId, payload);
    }


    [HttpPut("{hotelId}")]
    public Hotel Put(int hotelId, Hotel hotel)
    {

        return hotel;
    }
}

