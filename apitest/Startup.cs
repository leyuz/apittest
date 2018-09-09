using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apitest1.Onion.Core.Services;
using apitest1.Onion.Domain.Models;
using apitest1.Onion.Domain.Services;
using apittest.Onion.Infrastructure.DatabaseOperations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace apitest1 {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.Configure<CookiePolicyOptions> (options => {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_1);
            services.AddTransient<ICategoryService, CategoryService1> ();

            services.Configure<RazorViewEngineOptions> (o => {
                o.ViewLocationFormats.Clear ();
                o.ViewLocationFormats.Add ("onion/web/views/{1}/{0}" + RazorViewEngine.ViewExtension);
                o.ViewLocationFormats.Add ("onion/web/views/Shared/{0}" + RazorViewEngine.ViewExtension);
            });
            // Databases
            services.AddDbContext<ProductContext> (options => options.UseSqlServer (Configuration.GetConnectionString ("SimpleToDo")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler ("/Home/Error");
                app.UseHsts ();
            }

            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseCookiePolicy ();

            app.UseMvc (routes => {
                routes.MapRoute (
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}