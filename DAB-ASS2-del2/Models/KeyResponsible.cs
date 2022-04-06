using System.ComponentModel.DataAnnotations;

namespace DAB_ASS2.Models
{
    public class KeyResponsible
    {
        [Key]
        public int key_responsible_ID { get; set; }
        public string key_responsible_name { get; set; }
        public long key_responsible_CPR { get; set; }
        public string key_responsible_address { get; set; }
        public long key_responsible_phone { get; set; }
        public int key_responsible_photo_ID_number { get; set; }
    }
}