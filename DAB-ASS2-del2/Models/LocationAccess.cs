using System.ComponentModel.DataAnnotations;

namespace DAB_ASS2.Models
{
    public class LocationAccess
    {
        [Key]
        public int locationcodes_ID { get; set; }
        public int? locationcode { get; set; }
        public string? location_key_pickup_address { get; set; }

        public int locationId { get; set; }
        Location location { get; set; }
    }
}