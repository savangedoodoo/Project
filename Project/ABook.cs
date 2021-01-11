using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum status
    {
        good,
        medium,
        bad,
    }
    public class ABook
    {
        #region Định nghĩa dữ liệu
        public string BookID;
        public status Status;
        public Boolean Availability;
        public Book BookType;
        #endregion
        public ABook() { }
        public ABook(string BookID, status Status, Boolean Availability, Book BookType)
        {
            this.BookID = BookID;
            this.Status = Status;
            this.Availability = Availability;
            this.BookType = BookFactory.getBookType(BookType.ISBN, BookType.Title, BookType.Author, BookType.Publisher);
        }
        #region Định nghĩa các phương thức
        private static void Show_duedt()
        {

        }
        private status Reservation_status()
        {
            return this.Status;
        }
        private static void Book_request()
        {

        }
        #endregion
    }
}
