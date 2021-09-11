using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateRead { get; set; }
        public DateTime DateAdded { get; set; }
        public string Author { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }
    }
}
