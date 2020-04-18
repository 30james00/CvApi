using System.ComponentModel.DataAnnotations;

namespace CvApi.Models
{
    public class RegisterModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string RepPassword { get; set; }
    }
}