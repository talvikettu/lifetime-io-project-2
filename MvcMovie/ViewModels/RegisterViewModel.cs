using System.ComponentModel.DataAnnotations;

namespace MvcMovie.ViewModels
{
    public class RegisterViewModel {

    [Required(ErrorMessage ="Name is required")]
    public string Name {  get; set; }
    [Required(ErrorMessage ="email is required.")]
    [EmailAddress]
    public string Email {  get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(40,MinimumLength =8,ErrorMessage ="Use longer password")]
    [DataType(DataType.Password)]
    [Compare("ConfirmPassword",ErrorMessage ="Password does not match.")]
    public string Password { get; set; }

    [Required(ErrorMessage ="Confirm Password is required. ")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
    }
}
