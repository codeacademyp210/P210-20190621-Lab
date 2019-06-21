using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public long ISBN { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public DateTime PublishDate { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }
        public int AuthorID { get; set; }

        public Author Author { get; set; }
        public ICollection<Rating> Rating { get; set; }
        //public virtual ICollection<Author> Author { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

    }
}