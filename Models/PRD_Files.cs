using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model_UN_Crisis.Models
{
    public class PRD_Files
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ifile_Id { get; set; }
        public int Iconference_Id { get; set; }

        [Column(TypeName = "VARBINARY(MAX)")]
        public byte[] Bfile { get; set; }
    }
}
