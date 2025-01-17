﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-38ER4CK\\SQLEXPRESS;database=BlogV1; integrated security=true;");
        }
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<NewsLetter>? NewsLetters { get; set; }
        public DbSet<Writer>? Writers { get; set; }
        public DbSet<Proje>? Projes { get; set; }
    }
}
