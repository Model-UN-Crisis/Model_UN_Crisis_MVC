using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Model_UN_Crisis.Models
{
    public class STG_Directives
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idirective_Id { get; set; }
        public int Iauthor { get; set; }
        public int Ico_Author_1 { get; set; }
        public int Ico_Author_2 { get; set; }
        public int Iassigned_Staff { get; set; }
        public string Ctext { get; set; }
        public string Cstatus { get; set; }

        [Column(TypeName = "VARBINARY(MAX)")]
        public byte[] Bimage { get; set; }
    }
}
