using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Motorex.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Motorex.Models.Motor;

namespace Motorex.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Motor> Motors { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

      //  public DbSet<Motorex.Models.Motor.MotorCreateVM> MotorCreateVM { get; set; }
    }
}
