using System.ComponentModel.DataAnnotations.Schema;
using HotelApi.Enum;
namespace HotelApi.Models;


public class Hotel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string Location { get; set; } = "";
    public string Price { get; set; } = "";
    public bool Featured { get; set; }

    public virtual Media[]? Gallery { get; set; }
    public virtual WorkTime? WorkTime { get; set; }

    [ForeignKey("ImageId")]
    public virtual Media? Image { get; set; }
    public int? ImageId { get; set; }
    public List<FoodTypes> FoodTypes { set; get; } = new List<FoodTypes> { };
    public List<Review> Reviews { get; set; } = new List<Review> { };
}

