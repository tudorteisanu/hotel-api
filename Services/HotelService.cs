using System;
using AutoMapper;
using HotelApi.Dto;
using HotelApi.Enum;

using HotelApi.Models;
using HotelApi.Interfaces;

namespace HotelApi.Services;

public class HotelService : IHotelService
{
    private readonly IMapper mapper;

    public HotelService(IMapper _mapper)
    {
        mapper = _mapper;
    }

	public IEnumerable<FeaturedHotelDto> GetFeaturedHotels()
	{
        IEnumerable<Hotel> hotels = GetRandomHotels();
        return mapper.Map<IEnumerable<Hotel>, IEnumerable<FeaturedHotelDto>>(hotels);
    }

    public IEnumerable<FeaturedHotelDto> GetPopularHotels()
    {
        IEnumerable<Hotel> hotels = GetRandomHotels();
        return mapper.Map<IEnumerable<Hotel>, IEnumerable<FeaturedHotelDto>>(hotels);
    }

    public IEnumerable<Hotel> GetHotelsList()
    {
        return Enumerable.Range(1, 5).Select(index => new Hotel
        {
            Id = index,
            Name = $"Hotel name {index}",
            Location = $"Hotel Location {index}",
            Image = new Media { Id = 1, Path = "images/image_1" },
        });
    }

    private IEnumerable<Hotel> GetRandomHotels()
    {
        return Enumerable.Range(1, 4).Select(index => new Hotel
        {
            Id = index,
            Name = $"Hotel name {index}",
            Location = $"Connaught Place, Central Delhi {index}",
            FoodTypes = new List<string> { FoodTypes.Asian, FoodTypes.NorthernFood },
            Price = "asd asd a",
            Reviews = new List<Review>
            {
                new Review
                {
                    Id = 1,
                    Comment = "",
                    Value = (float)(Random.Shared.NextDouble() * (5 - 2) + 2)
                },
                new Review
                {
                    Id = 1,
                    Comment = "",
                     Value = (float)(Random.Shared.NextDouble() * (5 - 2) + 2)
                },
                new Review
                {
                    Id = 1,
                    Comment = "",
                    Value = (float)(Random.Shared.NextDouble() * (5 - 2) + 2)
                },
                new Review
                {
                    Id = 1,
                    Comment = "",
                     Value = (float)(Random.Shared.NextDouble() * (5 - 2) + 2)
                },
                new Review
                {
                    Id = 1,
                    Comment = "",
                    Value = (float)(Random.Shared.NextDouble() * (5 - 2) + 2)
                },
            },
            Image = new Media { Id = 2, Path = $"images/image_{index}.png" }
        });

    }
}

