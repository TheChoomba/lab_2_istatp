namespace lab_2_istatp.Models
{
    public class BookList
    {
        public BookList() 
        { 
            Books = new List<Book>();
        }
        public int Id { get; set; }
        public int PublisherHouseId { get; set; }
        public int bookId { get; set; }

        public PublisherHouse PublisherHouses { get; set; } = null!;
        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
