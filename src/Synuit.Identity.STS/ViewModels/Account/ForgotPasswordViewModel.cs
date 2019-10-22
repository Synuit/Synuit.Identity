using System.ComponentModel.DataAnnotations;

namespace Synuit.Identity.STS.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
