using Synuit.Identity.STS.Configuration.Intefaces;

namespace Synuit.Identity.STS.Configuration
{
    public class AdminConfiguration : IAdminConfiguration
    {
        public string IdentityAdminBaseUrl { get; set; } = "http://localhost:9000";
    }
}