namespace lab_2_istatp.Models
{
    public class Book
    {
        public Book()
        { 
            Genres = new List<Genre>();
        }
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int YearRealise { get; set; }
        public string Name { get; set; } = null!;
        public string Author { get; set; } = null!;

        public BookList BookLists { get; set; } = null!;
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    }
}
