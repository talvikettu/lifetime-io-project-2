using System.ComponentModel.DataAnnotations;

namespace MvcMovie.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required. ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="remember me?")]
        public bool RememberMe { get; set; }
    }
}
