using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model_UN_Crisis.Models
{
    public class STG_Messages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Imessage_Id { get; set; }
        public int Iauthor { get; set; }
        public int Igroup_Id { get; set; }
        public string Ctext { get; set; }
        public DateTime Ttimestamp { get; set; }
    }
}
