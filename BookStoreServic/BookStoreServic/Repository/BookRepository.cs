using BookStoreServic.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServic.Repository
{
    public class BookRepository : IBookRepository
    {
        IEnumerable<Book> _bookList;
        public BookRepository(IEnumerable<Book> bookList)
        {
            _bookList = bookList;

        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _bookList;
        }

        public IEnumerable<Book> GetBooksByAuthorName(string author)
        {
            return _bookList.Where(x => x.Author.Equals(author));
        }

        public IEnumerable<Book> GetBooksByCategory(string category)
        {
            return _bookList.Where(x => x.Category.Equals(category));
        }

        public void AddBook(Book book)
        {
            if(!_bookList.Contains(book))
            {
                _bookList.ToList().Add(book);
            }
        }

        public void UpdateBook(Book book)
        {
            if(!_bookList.Contains(book))
            {
                _bookList.ToList().Add(book);
            }
            else
            {
                _bookList.ToList().Remove(book);
                _bookList.ToList().Add(book)
            }
        }

        public void DeleteBook(Contract.Book book)
        {
            _bookList.ToList().Remove(book);
        }
    }
}
