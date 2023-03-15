using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Motorex.Data;
using Motorex.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Infrastructure
{
    public static class ApplicationBuilderExtension
    {
        public static async Task<IApplicationBuilder> PrepareDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            await RoleSeeder(services);
            await SeedAdministrator(services);

            var dataCategory = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedCategories(dataCategory);

            var dataBrand = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedBrands(dataBrand);
            return app;
        }

        public static async Task RoleSeeder(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Administrator", "Client", };

            IdentityResult roleResult;
            foreach (var role in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        public static async Task SeedAdministrator(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            if (await userManager.FindByNameAsync("admin") == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.FirstName = "admin";
                user.LastName = "admin";
                user.PhoneNumber = "0888888888";
                user.UserName = "admin";
                user.Email = "admin@admin.com";

                var result = await userManager.CreateAsync(user, "Admin123");
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }

        public static void SeedCategories(ApplicationDbContext dataCategory)
        {
            if (dataCategory.Categories.Any())
            {
                return;
            }

            dataCategory.Categories.AddRange(new[]
            {
                new Category{CategoryName="Street"},
                new Category{CategoryName="Super Bike"},
                new Category{CategoryName="Tourer"},
                new Category{CategoryName="Cross"},
                new Category{CategoryName="Scooter"},
                new Category{CategoryName="ATV"},
                new Category{CategoryName="Enduro"},
                new Category{CategoryName="Dresses"},
            });
            dataCategory.SaveChanges();
        }

        public static void SeedBrands(ApplicationDbContext dataBrand)
        {
            if (dataBrand.Brands.Any())
            {
                return;
            }

            dataBrand.Brands.AddRange(new[]
            {
                new Brand{BrandName="Kawasaki"},
                new Brand{BrandName="Honda"},
                new Brand{BrandName="Yamaha"},
                new Brand{BrandName="Ducati"},
                new Brand{BrandName="BMW"},
                new Brand{BrandName="Suzuki"},
                new Brand{BrandName="Husqvarna"},
                new Brand{BrandName="Polaris"},
                new Brand{BrandName="Aprilia"},
                new Brand{BrandName="KTM"},
                new Brand{BrandName="AGV"},
                new Brand{BrandName="Alpinestars"},
            });
            dataBrand.SaveChanges();
        }
    }
}

