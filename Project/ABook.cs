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
    class ABook
    {
        #region Định nghĩa dữ liệu
        private string BookID;
        private status Status;
        private Boolean Availability;
        private Book BookType;
        #endregion
        public ABook(string BookID, status Status, Boolean Availability, Book BookType)
        {
            this.BookID = BookID;
            this.Status = Status;
            this.Availability = Availability;
            this.BookType = BookType;
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
