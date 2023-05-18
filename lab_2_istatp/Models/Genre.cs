using System.ComponentModel.DataAnnotations;


namespace lab_2_istatp.Models
{
    public class Genre
    {
        public Genre()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
