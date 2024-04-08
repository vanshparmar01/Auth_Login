using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_Login.Models
{
    [NotMapped] // This tells EF Core that UserLogin is not an entity
    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
