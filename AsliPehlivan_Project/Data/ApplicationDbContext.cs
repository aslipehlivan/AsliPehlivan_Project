using System;
using System.Collections.Generic;
using System.Text;
using AsliPehlivan_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AsliPehlivan_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


    }
}
