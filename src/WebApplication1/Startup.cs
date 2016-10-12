using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebApplication1.Services;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using AutoMapper;
using WebApplication1.ViewModels;

namespace WebApplication1
{
    public class Startup
    {
        private IHostingEnvironment _env;
        private IConfigurationRoot _config;

        public Startup(IHostingEnvironment env)
        {
            _env = env;
            
            var configBuilder = new ConfigurationBuilder();
            configBuilder
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();

            _config = configBuilder.Build();
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_config);

            if (_env.IsDevelopment())
            {
                services.AddTransient<IMailService, DebugMailService>();
            }
            else
            {
                // Implement real service.
            }

            services.AddDbContext<ParkingContext>();

            services.AddTransient<ParkingContextSeedData>();

            services.AddScoped<IParkingRepository, ParkingRepository>();

            services.AddLogging();

            services.AddMvc()
                .AddJsonOptions(config => new JsonSerializerSettings() {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });
        }
        
        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory,
            ParkingContextSeedData seeder,
            ILoggerFactory factory)
        {
            Mapper.Initialize(config => {
                config.CreateMap<ParkingViewModel, Parking>().ReverseMap();
            });

            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                factory.AddDebug(LogLevel.Debug);
            }
            else
            {
                factory.AddDebug(LogLevel.Information);
            }

            app.UseStaticFiles();

            app.UseMvc(config => config.MapRoute(
                name: "Default",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "App", action = "Index" })
                );

            seeder.EnsureSeedData().Wait();
        }
    }
}
