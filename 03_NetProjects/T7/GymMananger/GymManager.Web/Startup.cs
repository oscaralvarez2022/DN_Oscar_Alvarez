using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Navigation;
using GymManager.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;

namespace GymMananger
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("Default");

            services.AddDbContext<GymManagerContext>(options =>
               options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount=true).AddEntityFrameworkStores<GymManagerContext>();

            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/LogIn");

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddTransient<iMembersAppService, MembersAppService>();

            services.AddTransient<IMenuAppService, MenuAppService>();

            /*services.AddSingleton<iMembersAppService, MembersAppService>();            
            services.AddScoped<iMembersAppService, MembersAppService>();*/


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var defaultDateCulture = "es-MX";
            var ci = new CultureInfo(defaultDateCulture);

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ci),
                SupportedCultures = new List<CultureInfo>
                {
                    ci,
                },
                SupportedUICultures = new List<CultureInfo>
                {
                    ci,
                }
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
