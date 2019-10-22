using Synuit.Identity.Admin.Api.Configuration.Constants;

namespace Synuit.Identity.Admin.Api.Configuration
{
    public class AdminApiConfiguration
    {
        public string IdentityServerBaseUrl { get; set; } = AuthorizationConsts.IdentityServerBaseUrl;

        public string OidcSwaggerUIClientId { get; set; } = AuthorizationConsts.OidcSwaggerUIClientId;

        public string OidcApiName { get; set; } = AuthorizationConsts.OidcApiName;
    }
}