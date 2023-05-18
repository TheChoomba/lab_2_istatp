namespace lab_2_istatp.Models
{
    public class Country
    {
        public Country()
        {
            PublisherHouses = new List<PublisherHouse>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<PublisherHouse> PublisherHouses{ get; set; } = new List<PublisherHouse>();   
    }
}
