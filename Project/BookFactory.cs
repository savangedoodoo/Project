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
            Book result = bookTypes[title];
            if (result == null)
            {
                result = new Book(isbn, title, author, publisher);
                bookTypes[title] = result;
            }
            return result;
        }
    }
}
