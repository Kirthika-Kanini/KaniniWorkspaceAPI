using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventApi.Models
{
    public class EventAndDesc
    {
        [Key]
        public int EventId { get; set; }
        public string? EventName { get; set; }
        public string ?EventDescription { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventStartTime { get; set; }
        public DateTime EventEndTime { get; set; }
        public string? EventImagePath { get; set; }
        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public Location? Location { get; set; }
        public ICollection<EventJoin>? EventJoins { get; set; }
      
    }
}
