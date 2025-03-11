using System.Collections.Generic;
using WebAppMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;


namespace WebAppMVC.Data
{

        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Item> Items { get; set; }
        }
    }








