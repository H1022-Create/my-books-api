using Microsoft.EntityFrameworkCore;
using my_books_api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books_api.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Book_Author>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.Book_Authors)
                .HasForeignKey(bi => bi.BookId);

            modelbuilder.Entity<Book_Author>()
               .HasOne(b => b.Author)
               .WithMany(ba => ba.Book_Authors)
               .HasForeignKey(bi => bi.AuthorId);

            modelbuilder.Entity<Log>()
                .HasKey(n => n.Id);


        }
        public DbSet<Book>Books { get; set; }
        public DbSet <Author> Authors { get; set; }
        public DbSet <Book_Author> Books_Authors { get; set; }
        public DbSet <Publisher> Publishers { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
