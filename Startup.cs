using DutchGo.Data;
using DutchGo.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Reflection;

namespace DutchGo
{
    public class Startup
    {
        private readonly IConfiguration _config;  
        
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DutchContext>(cfg =>
            {
                //OJO se realizo una modificacion de Configuration a _config
                cfg.UseSqlServer(_config.GetConnectionString("DutchConnectionString"));
            });

            services.AddTransient<IMailService, NullMailService>();

            services.AddTransient<DutchSeeder>();

            services.AddMvc();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IDutchRepository, DutchRepository>();

            services.AddControllersWithViews()
                    .AddRazorRuntimeCompilation()
                    .AddNewtonsoftJson(cfg => cfg.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
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
