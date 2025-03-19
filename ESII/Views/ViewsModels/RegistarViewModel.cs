using System.ComponentModel.DataAnnotations;

namespace ESII.ViewModels
{
    public class RegistarViewModel
    {
        [Required]
        public string Nome { get; set; }= string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas não correspondem.")]
        public string ConfirmarPassword { get; set; } = string.Empty;
    }
}