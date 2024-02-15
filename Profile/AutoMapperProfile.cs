using AutoMapper;
using HotelApi.Dto;
using HotelApi.Enum;
using HotelApi.Models;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Hotel, FeaturedHotelDto>()
            .ForMember(
                vm => vm.Rating,
                m => m.MapFrom(u => u.Reviews.Capacity > 0 ? u.Reviews.Average(acc => acc.Value) : 0)
             );
            //.ForMember(vm => vm.FoodTypes, hotel => hotel.MapFrom(m => m.FoodTypes.Select(item => GetFoodType(item))));
        CreateMap<Media, ImageWithUrlDto>()
            .ForMember(vm => vm.Url, m => m.MapFrom(u => u.GetUrl()));
        CreateMap<CreateHotelDto, Hotel>();
    }

    private string GetFoodType(FoodTypes foodType)
    {
        switch (foodType)
        {
            case FoodTypes.Asian:
                {
                    return "Asian";
                }
            case FoodTypes.Rose:
                {
                    return "Rose";
                }
            case FoodTypes.White:
                {
                    return "White";
                }
            default:
                {
                    return "";
                }
        }
    }
}