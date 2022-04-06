using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace DAB_ASS2.Models
{
    public class Chairman
    {
        [Key]
        public int chairmanid { get; set; }

        public string chairman_name { get; set; }
        public long chairman_CPR { get; set; }
        public string chairman_address { get; set; }
    }
}
