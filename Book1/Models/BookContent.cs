using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Book1.Models
{
    public class BookContent: DbContext
    {
        public BookContent(DbContextOptions<BookContent> options) :base(options)
        {
           
        }
         public DbSet<Book12> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book12>().HasNoKey();
        }
    }
}
