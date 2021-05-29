using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniverseDB.DataBase;
using UniverseDB.DataBase.Entities;
using UniverseDB.DataBase.Repositories;
using UniverseDB.DataBase.Repositories.Abstract;
using UniverseDB.DataBase.Repositories.EntityFramework;
using UniverseDB.Service;

namespace UniverseDB
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        
        public void ConfigureServices(IServiceCollection services) 
        {
            //подключаем конфиг из appsetings.json
            Configuration.Bind("Project", new Config());

            services.AddTransient<ICartRepository, EFCartRepository>();
            services.AddTransient<IDeveloperRepository, EFDeveloperRepository>();
            services.AddTransient<IGameGenreRepository, EFGameGenreRepository>();
            services.AddTransient<IGamesRepository, EFGamesRepository>();
            services.AddTransient<IGenreRepository, EFGenreRepository>();
            services.AddTransient<IPublisherRepository, EFPublisherRepository>();
            services.AddTransient<DataManager>();

            //подключаем контекст базы данных
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            //настраиваем identity систему
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //настраиваем authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
            options.Cookie.Name = "UniverseCookie";
            options.Cookie.HttpOnly = true;
            options.LoginPath = "/account/login";
            options.AccessDeniedPath = "/account/accessdenied";
            options.SlidingExpiration = true;
        });

            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy =>
                {
                    policy.RequireRole("admin");
                });
                x.AddPolicy("UserArea", policy =>
                {
                    policy.RequireRole("user");
                });
            });

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(options => //CookieAuthenticationOptions
            //    {
            //        options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/account/login");
            //    });

            // поддержка контролеров и представлений
            services.AddControllersWithViews(x=>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
                x.Conventions.Add(new UserAreaAuthorization("User", "UserArea"));

            })
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //поддержка статичных фалов
            app.UseStaticFiles();

            app.UseRouting();

            //подключаем аунтентификацию и авторизацию
            app.UseCookiePolicy();
            app.UseAuthorization();
            app.UseAuthentication();
            

            app.UseEndpoints(endpoints =>
            {
                /* endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Hello World! fffff");
                 });*/
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Admin}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("register", "{area:exists}/{controller=User}/{action=Index}/{id?}");
            });
        }
    }
}
