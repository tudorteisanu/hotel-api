using HotelApi.Dto;
using HotelApi.Interfaces;
using HotelApi.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Services;

public class ProfileService : IProfileService
{
    private readonly AppDbContext dbContextClass;
    private readonly IMapper mapper;

    public ProfileService(AppDbContext dbContextClass, IMapper _mapper)
    {
        this.dbContextClass = dbContextClass;
        mapper = _mapper;
    }

    public List<Review> GetReviews()
    {
        return dbContextClass.Review.Include(r => r.Author).Where(r => r.AuthorId == 2).ToList();
    }

}
   

