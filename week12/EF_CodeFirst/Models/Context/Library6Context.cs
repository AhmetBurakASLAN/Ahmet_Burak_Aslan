using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EF_CodeFirst.Models.Entities;


namespace EF_CodeFirst.Models.Context
{
    public class Library6Context:DbContext
    {
        public Library6Context(DbContextOptions<Library6Context>options) : base(options)
        {
           

        }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Author> Authors  { get; set; }
        public DbSet<Publisher> Publishers  { get; set; }
        public DbSet<Book> Books  { get; set; }
        public DbSet<Member> Members  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured) //opstions builder configure edilmemeişse yani veri tabanı ayarları yapılmamıssa
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:LibraryConn");
            }

        }
    }
}