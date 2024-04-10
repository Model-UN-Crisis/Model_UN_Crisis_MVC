using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model_UN_Crisis.Models
{
    public class PRD_Conferences
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Iconference_Id { get; set; }
        public int Iprimary_Admin { get; set; }
    }
}
