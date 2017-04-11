using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel() //gör det IIS skulle göra, men för X-platform
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration() //säkerhet mm över IIS 
                .UseStartup<Startup>() //Här specar vi konfig
                .UseApplicationInsights() //om vi deployar till Azure kan vi få statistik om klick mm
                .Build();

            host.Run();
        }
    }
}
