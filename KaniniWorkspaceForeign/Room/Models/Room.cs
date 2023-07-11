using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomApi.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string? RoomName { get; set; }
        public string? RoomImagePath { get; set; }
        public int RoomCapacity { get; set; }
        public string? Presentation { get; set; }
        public string? Additional { get; set; }
        [ForeignKey("LocationId")]
        public int LocationId { get; set; }

        public Location? Location { get; set; }

        public ICollection<RoomBooking>? RoomBookings { get; set; }
    }
}
