using System.Collections.Generic;

namespace BookStore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}