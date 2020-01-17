using FurnitureShop.DAL;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;

namespace FurnitureShop
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromHours(10);
            //    options.Cookie.IsEssential = true;
            //    options.Cookie.HttpOnly = false;
            //    options.Cookie.Name = "MyAppSession";
            //    //options.Cookie.Domain = "/";
            //});

            services.AddIdentity<FurnitureUser, IdentityRole>(options =>
             {
                // Password settings.
                options.Password.RequireDigit = true;
                 options.Password.RequireLowercase = true;
                 options.Password.RequireUppercase = true;
                 options.Password.RequiredLength = 8;
                 options.Password.RequiredUniqueChars = 3;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                 options.Lockout.MaxFailedAccessAttempts = 7;
                 options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                 "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                 options.User.RequireUniqueEmail = true;
             })

             

            .AddEntityFrameworkStores<FurnitureContext>()
            .AddDefaultUI()

            .AddDefaultTokenProviders();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.Configure<CookieOptions>(options =>
            {
                options.HttpOnly = true;
                options.IsEssential = true;
                options.MaxAge = TimeSpan.FromMinutes(5);
            });

            services.
                AddMvc()
                 .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            services.AddDbContext<FurnitureContext>(options =>
            {
                options.UseSqlServer(_configuration["Data:ConnectionStrings:Default"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseAuthentication();

            //app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                    );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
