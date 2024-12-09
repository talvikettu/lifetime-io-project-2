using System.ComponentModel.DataAnnotations;

namespace MvcMovie.ViewModels
{
    public class ChangePasswordViewModel
    {   
        [Required(ErrorMessage = "email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Use longer password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New password")]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm Password is required. ")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm New password")]
        public string ConfirmNewPassword { get; set; }
    }
}
