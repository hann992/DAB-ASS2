using System.ComponentModel.DataAnnotations;

namespace DAB_ASS2.Models
{
    public class RoomProperty
    {
        [Key]
        public int roomproperties_ID { get; set; }
        public string room_property_name { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
