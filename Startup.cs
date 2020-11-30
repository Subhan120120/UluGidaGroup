using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using UluGida.Models.Context;

namespace UluGidaGroup
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOutputCaching();
            services.AddDistributedMemoryCache(); //before AddControllersWithViews
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddControllersWithViews().AddSessionStateTempDataProvider();
            services.AddDbContext<UluContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("UluDBString")));

            //RepositoryDIImplementation(services);
        }

        private void RepositoryDIImplementation(IServiceCollection services)
        {
            //services.AddScoped<IRepository<AppDetail>, AppDetailRepository>();
            //services.AddScoped<IRepository<MenuItem>, MenuItemRepository>();
            //services.AddScoped<IRepository<MenuItemGroup>, MenuItemGroupRepository>();
            //services.AddScoped<IRepository<Reservation>, ReservationRepository>();
            //services.AddScoped<IRepository<DineInTable>, DineInTableRepository>();
            //services.AddScoped<IRepository<DineInTableGroup>, DineInTableGroupRepository>();
            //services.AddScoped<IRepository<Order>, OrderRepository>();
            //services.AddScoped<IRepository<Customer>, CustomerRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions()
            {
                RequestPath = new PathString("/npm"),
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules"))
            });

            app.UseOutputCaching();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                    //defaults: new { area = "Admin", controller = "Dashboard", action = "Index" }
                    );                    
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
