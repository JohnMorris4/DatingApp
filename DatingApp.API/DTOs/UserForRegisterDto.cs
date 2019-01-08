using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username  { get; set; }
        
        [Required]
        [StringLength(15, MinimumLength = 8, ErrorMessage= "You must have a password between 8 and 15 characters")]
        public string Password { get; set; }

    }
}