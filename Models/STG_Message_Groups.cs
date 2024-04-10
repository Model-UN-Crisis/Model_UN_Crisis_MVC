using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model_UN_Crisis.Models
{
    public class STG_Message_Groups
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Igroup_Id { get; set; }
        public int Iuser_Id { get; set; }
    }
}
