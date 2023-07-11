using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventApi.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public string? NotificationTitle { get; set; }
        public DateTime NotificationDate { get; set; }
        public DateTime NotificationTime { get; set; }
        public string? NotificationDesc { get; set; }

        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public Location? Location { get; set; }

      
    }
}
