using Microsoft.EntityFrameworkCore;

namespace lab_2_istatp.Models
{
    public class LabAPIContext : DbContext
    {
        public LabAPIContext()
        {
        }



        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookList> BookList { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<PublisherHouse> PublisherHouse { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=TheChoomba;Database=LAPI;Trusted_Connection=True;");
        //}
        public LabAPIContext(DbContextOptions<LabAPIContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
    }
}
