using AutoMapper;
using HotelApi.Dto;
using HotelApi.Models;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Hotel, FeaturedHotelDto>()
            .ForMember(vm => vm.Rating, m => m.MapFrom(u => u.Reviews.Select(acc => acc.Value).Average()));

        CreateMap<Media, ImageWithUrlDto>()
            .ForMember(vm => vm.Url, m => m.MapFrom(u => u.GetUrl()));
    }
}