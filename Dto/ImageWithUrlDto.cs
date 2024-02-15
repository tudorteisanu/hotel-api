using System;
using HotelApi.Models;

namespace HotelApi.Dto;
public class ImageWithUrlDto
{
	public required int Id { get; set; }
	public required string Url { get; set; }
}

