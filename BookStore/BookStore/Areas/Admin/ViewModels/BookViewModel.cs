using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Areas.Admin.ViewModels
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public List<Category> Categories { get; set; }
    }
}