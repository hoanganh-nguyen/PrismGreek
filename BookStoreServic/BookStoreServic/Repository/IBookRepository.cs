using BookStoreServic.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServic.Repository
{
    public interface IBookRepository
    {
        //Select
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> GetBooksByAuthorName(string author);
        IEnumerable<Book> GetBooksByCategory(string category);

        //Insert
        void AddBook(Book book);

        //Update
        void UpdateBook(Book book);

        //Delete
        void DeleteBook(Book book);

    }
}
