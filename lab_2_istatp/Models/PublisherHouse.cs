using System.ComponentModel.DataAnnotations;

namespace lab_2_istatp.Models
{
    public class PublisherHouse
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Error Public house model")]
        [Display(Name = "Publisher house")]
        public int CountryId { get; set; }

        public int BookList { get; set; }
        public string Name { get; set; } = null!;

        public Country Countrys { get; set; } = null!;
        public BookList BookLists { get; set; } = null!;
    }
}
