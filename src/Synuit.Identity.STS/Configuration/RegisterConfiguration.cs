using Synuit.Identity.STS.Configuration.Intefaces;

namespace Synuit.Identity.STS.Configuration
{
    public class RegisterConfiguration : IRegisterConfiguration
    {
        public bool Enabled { get; set; } = true;
    }
}
