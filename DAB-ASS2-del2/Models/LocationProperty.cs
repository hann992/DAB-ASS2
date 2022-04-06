using System.ComponentModel.DataAnnotations;

namespace DAB_ASS2.Models
{
    public class LocationProperty
    {
        [Key]
        public int locationproperties_ID { get; set; }
        public string location_property_name { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}
