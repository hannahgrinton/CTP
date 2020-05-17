using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
namespace CTP.Models
{
    public class BookManager : DbContext
    {
        public DbSet<Book> ebooks { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Book> booklets { get; set; }
        public DbSet<Book> study { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(Connection.CONNECTION_STRING);
        }
    }
}