using CalculatorService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    [ServiceContract]
    interface IBookStoreService
    {

        // Select
        [OperationContract]
        IEnumerable<Book> GetAllBooks();
        [OperationContract]
        IEnumerable<Book> GetBooksByAuthorName();
        [OperationContract]
        IEnumerable<Book> GetBooksByCategory();

        //Delete
        [OperationContract]
        bool DeleteBook(Book book);

        //Insert
        [OperationContract]
        bool InsertBook(Book book);

        //Update
        [OperationContract]
        bool UpdateBook(Book book);


    }
}
