using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;

namespace Synuit.Identity.STS
{
   public class Program
   {
      public static void Main(string[] args)
      {
         CreateWebHostBuilder(args)
            .UseSerilog()
         .Build().Run();
      }

      public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
          WebHost.CreateDefaultBuilder(args)
              .UseStartup<Startup>();
   }
}