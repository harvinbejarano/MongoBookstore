using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Core
{
    public class BookService : IBookService
    {
        private readonly IMongoCollection<Book> _books;

        public BookService(IDbClient dbclient)
        {
            _books = dbclient.GetBooksCollection();
        }

        public Book AddBook(Book book)
        {
           _books.InsertOne(book);

            return book;
        }

        public Book GetBook(string id)
        {
            return _books.Find(book => book.Id == id).First();
        }

        public List<Book> GetBooks() =>_books.Find(book => true).ToList();
    }
}
