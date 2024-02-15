using Microsoft.AspNetCore.Mvc;
using HotelApi.Interfaces;
using HotelApi.FileUpload;

namespace hotel_api.Controllers;

public class UploadFileController : Controller
{
    private IFileService fileService;
    public UploadFileController(IFileService _fileService)
    {
        fileService = _fileService;
    }

    [HttpPost("PostSingleFile")]
    public async Task<ActionResult> PostSingleFile([FromForm] FileUploadModel fileDetails)
    {
        if (fileDetails == null)
        {
            return BadRequest();
        }

        try
        {
            await fileService.PostFileAsync(fileDetails.Details);
            return Ok();
        }
        catch (Exception)
        {
            throw;
        }
    }
}

