using System.ComponentModel.DataAnnotations;

namespace DAB_ASS2.Models
{
    public class Society
    {
        [Key]
        public int society_ID { get; set; }
        public long society_CVR { get; set; }
        public string society_name { get; set; }
        public string society_activity { get; set; }
        public int society_member_count { get; set; }

        //shadow property
        public int chairmanid { get; set; }
        Chairman chairman { get; set; }
    }
}
