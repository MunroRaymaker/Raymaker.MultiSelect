using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Raymaker.MultiSelect.Middleware;
using Raymaker.MultiSelect.Models;
using Raymaker.MultiSelect.Services;

namespace Raymaker.MultiSelect
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
            services.AddRazorPages();
            services.Configure<PizzaOptions>(Configuration);
            services.Configure<EmailOptions>(Configuration);
            services.AddMemoryCache();
            services.AddTransient<ICarService, CarService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseExceptionHandler("/Error");

            app.UseElapsedTimeMiddleware();

            app.UseStaticFiles();
            app.UseRouting();
            
            app.UseStatusCodePagesWithRedirects("/errors/{0}");
            
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                // Add any legacy routes here
                endpoints.MapGet("legacy.aspx", async context =>
                {
                    var query = context.Request.QueryString;
                    await Task.Run(() => context.Response.Redirect("/legacy" + query.Value));
                });
            });
        }
    }
}