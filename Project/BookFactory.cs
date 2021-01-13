using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class BookFactory
    {
        public static Dictionary<string, Book> bookTypes = new Dictionary<string, Book>();

        public static Book getBookType(string isbn, string title, string author, string publisher)
        {
            if (bookTypes.ContainsKey(isbn)) return bookTypes[isbn];
            else
            {
                Book result = new Book(isbn, title, author, publisher);
                bookTypes.Add(isbn,result);
                return result;
            }
        }
        public static Book getBookType(Book book)
        {
            if (bookTypes.ContainsKey(book.ISBN)) return bookTypes[book.ISBN];
            else
            {
                bookTypes.Add(book.ISBN, book);
                return book;
            }
        }
    }
}
