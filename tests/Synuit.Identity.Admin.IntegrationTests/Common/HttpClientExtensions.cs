﻿using System.Net.Http;
using Synuit.Identity.Admin.Configuration.Constants;
using Synuit.Identity.Admin.Middlewares;

namespace Synuit.Identity.Admin.IntegrationTests.Common
{
    public static class HttpClientExtensions
    {
        public static void SetAdminClaimsViaHeaders(this HttpClient client)
        {
            client.DefaultRequestHeaders.Add($"{AuthenticatedTestRequestMiddleware.TestUserPrefixHeader}-{AuthenticatedTestRequestMiddleware.TestUserId}", "1");
            client.DefaultRequestHeaders.Add($"{AuthenticatedTestRequestMiddleware.TestUserPrefixHeader}-{AuthenticatedTestRequestMiddleware.TestUserName}", "test");
            client.DefaultRequestHeaders.Add($"{AuthenticatedTestRequestMiddleware.TestUserPrefixHeader}-{AuthenticatedTestRequestMiddleware.TestUserRoles}", AuthorizationConsts.AdministrationRole);
        }

    }
}
