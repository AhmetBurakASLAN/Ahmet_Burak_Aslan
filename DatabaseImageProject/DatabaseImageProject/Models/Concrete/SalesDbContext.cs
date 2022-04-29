using DatabaseImageProject.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Concrete
{
    public class SalesDbContext:DbContext
    {
        public SalesDbContext()
        {
        }

        public SalesDbContext(DbContextOptions<SalesDbContext>options):base(options)
        {

        }
        public DbSet<Product> MyProperty { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8M7D7GE\\SQLEXPRESS;Database=ProductDbSabah;Trusted_Connection=true;");
        }


    }
}
