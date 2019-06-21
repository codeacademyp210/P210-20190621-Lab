namespace BookStore.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public float Point { get; set; }
        public int BookId { get; set; }
        
        public Book Book { get; set; }
    }
}