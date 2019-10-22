using Microsoft.Extensions.Options;
using Synuit.Identity.Admin.Configuration.Interfaces;

namespace Synuit.Identity.Admin.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {
        public IAdminConfiguration AdminConfiguration { get; set; }

        public RootConfiguration(IOptions<AdminConfiguration> adminConfiguration)
        {
            AdminConfiguration = adminConfiguration.Value;
        }
    }
}
