using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeskApi.Models
{
    public class DeskBooking
    {
        [Key]
        public int DeskBookingId { get; set; }
        public DateTime DeskBookingDate { get; set; }
        public string? DeskBookingColleague { get; set; }
       
        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public Location? Location { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public User? Users { get; set; }
    }
}
