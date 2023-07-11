using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventApi.Models
{
    public class EventJoin
    {
        [Key]
        public int EventJoinId { get; set; }
        public int TotalEventJoin { get; set;}

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public User? Users { get; set; }
        [ForeignKey("EventId")]
        public int EventId { get; set; }

        public EventJoin? EventJoins { get; set; }

    }
}

