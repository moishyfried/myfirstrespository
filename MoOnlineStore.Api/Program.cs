using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MoOnlineStore.Api.Controllers;
using MoOnlineStore.Presistene;

namespace MoOnlineStore.Api
{
    public class Program
    {
        public ProductsController _ProductsController { get; }

        public Program(ProductsController productsController)
        {
            _ProductsController = productsController;
        }

        public static async Task Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {   
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                
                    var context = services.GetRequiredService<StoreContext>();
                   await context.Database.MigrateAsync();
            
                    await StoreContextSeed.SeedAsync(context, loggerFactory);
               try
                { }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(ex, "An error occured during migration");
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
