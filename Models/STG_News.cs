using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model_UN_Crisis.Models
{
    public class STG_News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Inews_Id { get; set; }
        public int Iconference_Id { get; set; }
        public string Ctext { get; set; }
    }
}
