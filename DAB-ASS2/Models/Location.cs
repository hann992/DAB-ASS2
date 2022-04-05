using System.ComponentModel.DataAnnotations;

namespace DAB_ASS2.Models
{
    public class Location
    {
        [Key]
        public int location_ID { get; set; }
        public string location_address { get; set; }
        public int location_zipcode { get; set; }
        public string location_name { get; set; }

        public ICollection<LocationProperty> locationProperties { get; set; }
    }
}
