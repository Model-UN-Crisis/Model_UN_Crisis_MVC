using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_UN_Crisis.Models
{
    public class STG_Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Iuser_id { get; set; }
        public string Cusername { get; set; }
        public string Cpassword { get; set; }
        public string Cemail { get; set; }
        public string CaccountType { get; set; }
    }
}
