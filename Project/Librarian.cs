using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    public class Librarian:Person
    {
        public string Account;
        public string Password;
        public string Home_Address;
        public Librarian() { }
        public Librarian(string Account,string Name,string Password,string Home,string Email,string Phone,string ID,DateTime DateofBirth)
        {
            this.Account = Account;
            this._Username = Name;
            this.Password = Password;
            this.Home_Address = Home;
            this._Email = Email;
            this._PhoneNum = Phone;
            this._ID = ID;
            this.DateofBirth = DateofBirth;
        }
        public void check_if_any()
        {

        }

        public static void add_abook(string BookID, status Status, Boolean Availability, Book BookType)
        {
            Database database = Database.GetDatabase();
            ABook book = new ABook(BookID, Status, Availability, BookType);
            database.listBook.Add(book);
        }

        public static void remove_abook(string BookID)
        {
            Database database = Database.GetDatabase();
            if (database.listBook.Any(item =>item.BookID==BookID))
            {
                //Dùng cách này mới trỏ tới đúng phần tử cần remove
                database.listBook.Remove(database.listBook.Find(item => item.BookID == BookID));
            }
        }
        public static bool check_Email(string email)
        {
            string regex2 = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex re2 = new Regex(regex2);
            return re2.IsMatch(email);
        }

    }
}