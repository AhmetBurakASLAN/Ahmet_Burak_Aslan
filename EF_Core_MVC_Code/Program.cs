using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EF_Core_MVC_Code
{
    /*  SqlServer paketi:
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.15
        dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.15
        dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
   */
    public class Program
    {
        public static void Main(string[] args)
        {
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
