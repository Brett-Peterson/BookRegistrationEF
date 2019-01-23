using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationEF
{
    static class BookDb
    {
        public static List<Book> GetAllBooks()
        {
            //create object to connect query to Db
            BookRegContext context = new BookRegContext();
            //Use Linq to query the context
            //List<Book> allBooks =
            //    (from b in context.Book
                    //where can go here
             //   select b).ToList();
             //Linq Method syntax
            List<Book> allBooks = context.Book.ToList();
            return allBooks;
        }
        public static void AddBook(Book b)
        {
            BookRegContext context = new BookRegContext();
            //Adds b to list of pending querys
            context.Book.Add(b);
            //Executes all pending actions(CRUD)
            context.SaveChanges();
        }

    }
}
