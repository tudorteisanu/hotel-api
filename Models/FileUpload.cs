using Microsoft.VisualBasic.FileIO;

namespace HotelApi.FileUpload;

public class FileUploadModel
{
    public required IFormFile Details { get; set; }
}