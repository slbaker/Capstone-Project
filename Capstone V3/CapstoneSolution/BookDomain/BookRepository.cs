using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDomain
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        Book GetBookByID(int ID);
        List<Book> GetBooksByAuthor(string authorName);
        bool AddBook(Book book);
        bool UpdateBook(Book book);
        bool DeleteBook(Book book);
    }
}
