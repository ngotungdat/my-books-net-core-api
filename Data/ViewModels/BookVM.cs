using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }
    }
}
