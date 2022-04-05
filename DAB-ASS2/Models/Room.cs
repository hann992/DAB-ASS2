using System.ComponentModel.DataAnnotations;

namespace DAB_ASS2.Models
{
    public class Room
    {
        [Key]
        public int room_ID { get; set; }
        public string room_name { get; set; }
        public int room_capacity { get; set; }

        public ICollection<RoomProperty> Roomproperties { get; set; }

        public int location_ID { get; set; }
        Location location { get; set; }

    }
}
