using System.ComponentModel.DataAnnotations;

namespace EventApi.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string? LocationCity { get; set; }
         
        public ICollection<EventAndDesc> ? EventAndDescs { get; set; }
        public ICollection<Notification>? Notifications { get; set; }
    }
}
