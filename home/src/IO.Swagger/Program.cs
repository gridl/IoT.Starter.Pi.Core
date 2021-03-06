using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace IO.Swagger
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel(options =>
                {
                    // options.ThreadCount = 4;
                    // options.UseHttps("cert.pfx", "certpassword");
                    //options.NoDelay = true;
                    //options.UseConnectionLogging();
                })
                .UseUrls("http://+:5010" /*, "https://+:5011" */)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
