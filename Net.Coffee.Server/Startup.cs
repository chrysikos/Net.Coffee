using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Net.Coffee.Server.Domain;
using Net.Coffee.Server.Hubs;
using Net.Coffee.Server.Persistence;
using psv.SFP.ApiSpecification;

namespace Net.Coffee.Server
{
    public class Startup
    {
        private IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;

        }

        public void ConfigureServices(IServiceCollection services)
        {
            #region Infrastructure
            //AutoMapper
            //var config = new MapperConfiguration(cfg =>
            //{

            //});
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //Entity Framework Core
            services.AddDbContext<MyDbContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString("NetCoffee")));

            //Asp .Net
            services.AddSignalR(options =>
            {

            });
            services.AddControllers(options =>
                {
                    options.AddRJes();
                })
                 .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);


            #endregion

            #region Domain
            services.AddScoped<UnitOfWork, UnitOfWork>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            #endregion
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ClientsHub>("/ClientsHub");
                endpoints.MapControllers();
            });
        }
    }
}
