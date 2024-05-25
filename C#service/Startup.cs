using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_service
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Register the service with the DI container
            services.AddTransient<IDatabase, GDLServiceClass>();
        }

        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    // Configure the application
        //}
    }
}
