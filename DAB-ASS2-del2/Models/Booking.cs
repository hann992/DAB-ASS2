using System.ComponentModel.DataAnnotations;

namespace DAB_ASS2.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        public DateTime booking_from { get; set; }
        public DateTime booking_to{ get; set; }

        public int society_Id { get; set; }
        Society society { get; set; }

        public int room_Id { get; set; }
        Room room { get; set; }

    }
}
