using HotelApi.Models;

namespace HotelApi.Interfaces;

public interface IProfileService
{
    public List<Review> GetReviews();
}

