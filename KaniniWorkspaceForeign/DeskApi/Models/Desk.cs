using System.ComponentModel.DataAnnotations.Schema;

namespace DeskApi.Models
{
    public class Desk
    {

        public int DeskId { get; set; }
        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public Location? Location { get; set; }

    }
}
