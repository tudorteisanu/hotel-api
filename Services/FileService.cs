using HotelApi.Dto;
using HotelApi.Interfaces;
using HotelApi.Models;
using AutoMapper;

namespace HotelApi.Services;

public class FileService : IFileService
{
    private readonly AppDbContext dbContextClass;
    private readonly IMapper mapper;

    public FileService(AppDbContext dbContextClass, IMapper _mapper )
    {
        this.dbContextClass = dbContextClass;
        mapper = _mapper;
    }

    public async Task<ImageWithUrlDto> PostFileAsync(IFormFile fileData)
    {
        try
        {
            var folderName = Path.Combine("wwwroot", "images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            var fileName = fileData.FileName;
            var fullPath = Path.Combine(pathToSave, fileName);
            var dbPath = Path.Combine("images", fileName);


            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                fileData.CopyTo(stream);
            }

            var fileDetails = new Media
            {
                Path = dbPath,
                Type = fileData.ContentType,
                Size = fileData.Length,
            };

            var result = dbContextClass.Media.Add(fileDetails);
            await dbContextClass.SaveChangesAsync();
            return mapper.Map<ImageWithUrlDto>(fileDetails);
        }
        catch (Exception)
        {
            throw;
        }
    }
}

