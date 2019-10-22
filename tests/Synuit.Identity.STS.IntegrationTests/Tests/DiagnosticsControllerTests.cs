using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Synuit.Identity.STS.IntegrationTests.Common;
using Xunit;

namespace Synuit.Identity.STS.IntegrationTests.Tests
{
    public class DiagnosticsControllerTests : IClassFixture<TestFixture>
    {
        private readonly HttpClient _client;

        public DiagnosticsControllerTests(TestFixture fixture)
        {
            _client = fixture.Client;
        }

        [Fact]
        public async Task UnAuthorizeUserCannotAccessDiagnosticsView()
        {
            // Clear headers
            _client.DefaultRequestHeaders.Clear();

            // Act
            var response = await _client.GetAsync("/Diagnostics/Index");

            // Assert      
            response.StatusCode.Should().Be(HttpStatusCode.Redirect);

            //The redirect to login
            response.Headers.Location.ToString().Should().Contain("Account/Login");
        }
    }
}
