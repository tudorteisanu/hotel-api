using System;

namespace HotelApi.Models;

public class WorkTime
{
    public int Id { set; get; }
    public required string From { get; set; }
    public required string To { get; set; }
}

