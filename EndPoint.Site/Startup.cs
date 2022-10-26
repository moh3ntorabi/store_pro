using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Persistence.Contexts;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Application.Services.Users.Queries.GetUsers;
using Phoenix_Store.Application.Services.Users.Queries.GetRoles;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Phoenix_Store.Application.Services.Users.Commands.EditUser;
using Phoenix_Store.Application.Services.Users.Commands.RegisterUser;
using Phoenix_Store.Application.Services.Users.Commands.RemoveUser;
using Phoenix_Store.Application.Services.Users.Commands.UserLogin;
using Phoenix_Store.Application.Services.Users.Commands.UserStatusChange;
using Phoenix_Store.Application.Interfaces.FacadPatterns;
using Phoenix_Store.Application.Services.Products.FacadPattern;
using Phoenix_Store.Application.Services.Common.Queries.GetMenuItem;
using Phoenix_Store.Application.Services.Common.Queries.GetCategory;
using Phoenix_Store.Application.Services.HomePages.AddNewSlider;
using Phoenix_Store.Application.Services.Common.Queries.GetSlider;
using Phoenix_Store.Application.Services.HomePages.AddHomePageImages;
using Phoenix_Store.Application.Services.Common.Queries.GetHomePageImages;
using Phoenix_Store.Application.Services.Carts;
using Phoenix_Store.Application.Services.Finances.Commands.AddRequestPay;
using Phoenix_Store.Common.Roles;
using Phoenix_Store.Application.Services.Finances.Queries.GetRequestPay;
using Phoenix_Store.Application.Services.Orders.Commands.AddNewOrder;
using Phoenix_Store.Application.Services.Orders.Queries.GetUserOrders;
using Phoenix_Store.Application.Services.Orders.Queries.GetOrdersForAdmin;
using Phoenix_Store.Application.Services.Finances.Queries.GetPayForAdmin;
using Phoenix_Store.Application.Services.HomePages.Queries.GetSlidersForAdmin;
using Phoenix_Store.Application.Services.HomePages.Commands.RemoveSlider;
using Phoenix_Store.Application.Services.HomePages.Queries.GetHomePageImagesForAdmin;
using Phoenix_Store.Application.Services.HomePages.Commands.RemoveAddHomePageImages;

namespace EndPoint.Site
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
            services.AddAuthorization(options =>
                {
                    options.AddPolicy(UserRoles.Admin, policy => policy.RequireRole(UserRoles.Admin));
                    options.AddPolicy(UserRoles.Customer, policy => policy.RequireRole(UserRoles.Customer));
                    options.AddPolicy(UserRoles.Operator, policy => policy.RequireRole(UserRoles.Operator));
                });
            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Authentication/Signin");
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
                options.AccessDeniedPath=new PathString("/Authentication/Signin");
            });

            ///////////Users///////////
            services.AddScoped<IDataBaseContext, DataBaseContext>();
            services.AddScoped<IGetUsersService, GetUsersService>();
            services.AddScoped<IGetRolesService, GetRolesService>();
            services.AddScoped<IEditUserService, EditUserService>();
            services.AddScoped<IUserLoginService, UserLoginService>();
            services.AddScoped<IRemoveUserService, RemoveUserService>();
            services.AddScoped<IRegisterUserService, RegisterUserService>();
            services.AddScoped<IUserStatusChangeService, UserStatusChangeService>();

            ///FacadInject///
            services.AddScoped<IProductFacad, ProductFacad>();

            ///....
            services.AddScoped<IGetMenuItemService, GetMenuItemService>();
            services.AddScoped<IGetCategoryService, GetCategoryService>();
            services.AddScoped<IAddNewSliderService, AddNewSliderService>();
            services.AddScoped<IGetSliderService, GetSliderService>();
            services.AddScoped<IAddHomePageImagesService, AddHomePageImagesService>();
            services.AddScoped<IGetHomePageImagesService, GetHomePageImagesService>();
            services.AddScoped<IGetSlidersForAdminService, GetSlidersForAdminService>();
            services.AddScoped<IRemoveSliderService, RemoveSliderService>();
            services.AddScoped<IGetHomePageImagesForAdmin, GetHomePageImagesForAdmin>();
            services.AddScoped<IRemoveHomePageImages, RemoveHomePageImages>();


            services.AddScoped<ICartService, CartService>();

            services.AddScoped<IAddRequestPayService, AddRequestPayService>();
            services.AddScoped<IGetRequestPayService, GetRequestPayService>();
            services.AddScoped<IAddNewOrderService, AddNewOrderService>();
            services.AddScoped<IGetUserOrdersService, GetUserOrdersService>();
            services.AddScoped<IGetOrdersForAdminService, GetOrdersForAdminService>();
            services.AddScoped<IGetPayForAdminService, GetPayForAdminService>();


            string contectionString = Configuration["ConnectionStrings:SqlServer"];
;
            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(contectionString));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");


                endpoints.MapControllerRoute(
                   name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
