using my_books.Data.Models;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Service
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM book)
        {
            Book _book = new Book()
            {
                Title = book.Title,
                DateAdded = DateTime.Now,
                DateRead = DateTime.Now,
                Author = book.Author,
                Category = book.Category,
                Price = book.Price
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
        public List<Book> GetAll() => _context.Books.ToList();
        public Book GetById(int bookId) => _context.Books.FirstOrDefault(x => x.Id == bookId);
        public Book UpdateBookById(int bookId, BookVM book)
        {
            Book _book = _context.Books.FirstOrDefault(x => x.Id == bookId);
            if (_book != null)
            {
                _book.Title = book.Title;
                _book.DateAdded = DateTime.Now;
                _book.DateRead = DateTime.Now;
                _book.Author = book.Author;
                _book.Category = book.Category;
                _book.Price = book.Price;
                _context.SaveChanges();
            }
            return _book;
        }
        public void DeleteBookById(int bookId)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id == bookId);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
