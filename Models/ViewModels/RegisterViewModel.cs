using System.ComponentModel.DataAnnotations;

namespace WABank.Models.ViewModels
{
    public class RegisterViewModel
    {
        // Email, ConfirmEmail, Password, ConfirmPassword, Mobile
        [Required(ErrorMessage = "*Enter email")]
        [EmailAddress]
        [MinLength(5)]
        public string Email { get; set; }
        [Required(ErrorMessage = "*Re-enter email")]
        [EmailAddress]
        [Compare("Email", ErrorMessage = "*Not match!")]
        public string ConfirmEmail { get; set; }
        [Required(ErrorMessage = "*Enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "*Re-nter password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "*Not match!")]
        public string ConfirmPassword { get; set; }
        public string Mobile { get; set; }
    }
}
