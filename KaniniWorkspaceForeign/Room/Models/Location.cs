using System.ComponentModel.DataAnnotations;

namespace RoomApi.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string? LocationCity { get; set; }
         
        public ICollection<Room> ?Rooms { get; set; } 
    }
}
