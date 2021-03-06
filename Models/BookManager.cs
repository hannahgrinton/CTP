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

        public List<Ebook> ebookResults { get; set; }
        public List<Ministry> ministryResults { get; set; }
        public List<Booklet> bookletResults { get; set; }
        public List<Exposition> expositionResults { get; set; }

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

        //get booklet item
        public Booklet getBooklet(int id) {
            return booklets.Single(item => item.id == id);
        }

        //get ebook item
        public Ebook getEbook(int id) {
            return ebooks.Single(item => item.id == id);
        }

        //search ministry
        public void searchMinistry(string term) {
            ministryResults = ministry.Where(item => (item.title.Contains(term)) || (item.author.Contains(term))).ToList();
        }

        //search ebooks
        public void searchEbooks(string term) {
            ebookResults = ebooks.Where(item => (item.title.Contains(term)) || (item.author.Contains(term))).ToList();
        }

        //search expositions
        public void searchExpositions(string term) {
            expositionResults = expositions.Where(item => (item.title.Contains(term)) || (item.author.Contains(term))).ToList();
        }

        //search booklets
        public void searchBooklets(string term) {
            bookletResults = booklets.Where(item => (item.title.Contains(term)) || (item.author.Contains(term))).ToList();
        }
    }
}