using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RoomApi.Models
{
    public class RoomBooking
    {
        [Key]
        public int RoomBookingId { get; set; }
        public string? RoomMeetingDesc { get; set; }
        public int RoomBookingEmployeeCount { get; set; }
        public DateTime RoomBookingDate { get; set; }
        public DateTime RoomBookingStartTime { get; set; }
        public DateTime RoomBookingEndTime { get; set; }
        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public Location? Location { get; set; }

        [ForeignKey("RoomId")]
        public int RoomId { get; set; }

        public Room? Rooms { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public User? Users { get; set; }

    }
}
