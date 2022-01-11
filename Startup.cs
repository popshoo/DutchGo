using DutchGo.Data;
using DutchGo.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchGo
{
    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DutchContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("DutchConnectionString"));
            });

            services.AddTransient<DutchSeeder>();

            services.AddTransient<IMailService,NullMailService>();

            services.AddMvc();

            services.AddScoped<IDutchRepository, DutchRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(cfg => 
            {
                cfg.MapRazorPages();

                cfg.MapControllerRoute("Default",
                "/{controller}/{action}/{id?}",
                new {Controller = "App", action = "Index"});
            });
        }
    }
}
