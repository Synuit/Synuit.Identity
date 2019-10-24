using System;
using System.IO;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Synuit.Identity.STS.IntegrationTests.Common
{
    public class TestFixture : IDisposable
    {
        private readonly TestServer _testServer;

        public HttpClient Client { get; }

        public TestFixture()
        {
            var builder = new WebHostBuilder()
                .UseContentRoot(GetContentRootPath())
                .UseEnvironment(EnvironmentName.Staging)
                .UseStartup<Startup>();

            _testServer = new TestServer(builder);
            Client = _testServer.CreateClient();
        }

        private string GetContentRootPath()
        {
	        var testProjectPath = AppContext.BaseDirectory;
			const string relativePathToWebProject = @"../../../../../src/Synuit.Identity.STS/";

            return Path.Combine(testProjectPath, relativePathToWebProject);
        }

        public void Dispose()
        {
            Client.Dispose();
            _testServer.Dispose();
        }
    }
}