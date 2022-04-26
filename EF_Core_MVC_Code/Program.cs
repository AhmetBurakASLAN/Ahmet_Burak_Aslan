using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
/*
1)sqlserver paketi:sqlserver için
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.15

2)Tools paketi : scaffold gibi komutları kullanabilmek için
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.15

3)Design paketi : kontrolleri ototmatik eklemek  için
dotnet add package Microsoft.VisualStudio.web.CodeGeneration.Design --version 5.0.2

4)dotnet
*/

namespace EF_Core_MVC_Code
{
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
