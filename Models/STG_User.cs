using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_UN_Crisis.Models
{
    public class STG_Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Iuser_id { get; set; }

        [Required(ErrorMessage = "Username is empty")]
        public string Cusername { get; set; }

        [Required(ErrorMessage = "Password is empty")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character")]
        public string Cpassword { get; set; }

        [Required(ErrorMessage = "Email is empty")]
        [RegularExpression(@"^.*@.*$", ErrorMessage = "Email must contain @")]
        public string Cemail { get; set; }

        [Required(ErrorMessage = "Account type is empty")]
        [RegularExpression("^(Directive|Admin)$", ErrorMessage = "Account type must be either 'Directive' or 'Admin'")]
        public string CaccountType { get; set; }
    }
}
