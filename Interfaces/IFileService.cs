using HotelApi.Dto;
namespace HotelApi.Interfaces;

public interface IFileService
{
    public Task<ImageWithUrlDto> PostFileAsync(IFormFile fileData);
}

