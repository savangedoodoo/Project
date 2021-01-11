using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Librarian
    {
        public string name ;
        public string Street;
        public string City;
        public string State;
        public string Postal_Code;
        public string Country;

        Database database = Database.GetDatabase();
        public void check_if_any()
        {

        }

        public void add_abook(string BookID, status Status, Boolean Availability, Book BookType)
        {
            ABook book = new ABook(BookID, Status, Availability, BookType);
            database.listBook.Add(book);
        }

        public void remove_abook(string BookID, status Status, Boolean Availability, Book BookType)
        {

        }


    }
}
