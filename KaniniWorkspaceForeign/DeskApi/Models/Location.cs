using System.ComponentModel.DataAnnotations;

namespace DeskApi.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string? LocationCity { get; set; }

        public ICollection<Desk>? Desks { get; set; }
        public ICollection<DeskBooking>? DeskBookings { get; set; }

    }
}
