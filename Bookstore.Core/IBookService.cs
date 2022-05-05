using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Core
{
    public interface IBookService
    {
        List<Book> GetBooks();

        Book GetBook(string id);
        Book AddBook(Book book);
    }
}
