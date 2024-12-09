using System.ComponentModel.DataAnnotations;

namespace MvcMovie.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "email is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
