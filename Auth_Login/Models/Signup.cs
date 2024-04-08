using System.ComponentModel.DataAnnotations;

namespace Auth_Login.Models
{
    public class Signup
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public int contact { get; set; }
        [Required]
        public string password { get; set; }
    }
}
