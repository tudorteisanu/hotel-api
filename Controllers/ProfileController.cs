using HotelApi.Models;
using HotelApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace hotel_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase
{
    private readonly IProfileService profileService;

    public ProfileController (IProfileService _profileService)
    {
        profileService = _profileService;
    }

    [HttpGet("[action]")]
    public IEnumerable<Review> GetReviews()
    {
        return profileService.GetReviews();
    }
}

