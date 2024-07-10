using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoInterdisciplinar.Data;
using ProjetoInterdisciplinar.Models;
using ProjetoInterdisciplinar.Services;

namespace ProjetoInterdisciplinar {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services) {
            services.Configure<CookiePolicyOptions>(options => {

                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<ProjetoInterdisciplinarContext>(options =>
                    options.UseMySql(Configuration.GetConnectionString("ProjetoInterdisciplinarContext"), builder =>
                        builder.MigrationsAssembly("ProjetoInterdisciplinar")));

            services.AddScoped<SeedingService>();
            services.AddScoped<SellerService>();
            services.AddScoped<DepartmentService>();
            services.AddScoped<SalesRecordService>();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SeedingService seedingService) {

            var enUS = new CultureInfo("en-US");
            var localizationOptions = new RequestLocalizationOptions {

                DefaultRequestCulture = new RequestCulture(enUS),
                SupportedCultures = new List<CultureInfo> {enUS},
                SupportedUICultures = new List<CultureInfo> {enUS}
            };
            app.UseRequestLocalization(localizationOptions);

            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                seedingService.Seed();
            } else {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
