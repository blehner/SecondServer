using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new ServerContext())
            {
                
                //Elvileg itt mentenie kellene ???
                db.Versions.Add(new Version
                {
                    VersionName = "Elso verzio",
                    VersionNumber = 1,
                    VersionProgrammer = "LB"
                });
                               
                db.SaveChanges();
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
