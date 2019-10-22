using System.ComponentModel.DataAnnotations;

namespace Synuit.Identity.STS.ViewModels.Account
{
    public class LoginWithRecoveryCodeViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string RecoveryCode { get; set; }

        public string ReturnUrl { get; set; }
    }
}
