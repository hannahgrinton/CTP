using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
namespace CTP.Models
{
    public class BookManager : DbContext
    {
        public DbSet<Ebook> ebooks { get; set; }
        public DbSet<Ministry> ministry { get; set; }
        public DbSet<Booklet> booklets { get; set; }
        public DbSet<Exposition> expositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(Connection.CONNECTION_STRING);
        }
        //get ministry item
        public Ministry getMinistry(int id) {
            return ministry.Single(item => item.id == id);
        }

        //get exposition item
        public Exposition getExposition(int id) {
            return expositions.Single(item => item.id == id);
        }

        
    }
}