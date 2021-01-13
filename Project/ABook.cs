using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
    [Serializable]
    public class ABook:ISerializable
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
        public ABook(SerializationInfo info, StreamingContext ctxt)
        {
            //định nghĩa lại phương thức Deserialization
            BookID = (string)info.GetValue("BookID", typeof(string));
            Status = (status)info.GetValue("Status", typeof(status));
            Availability = (bool)info.GetValue("Availability", typeof(bool));
            BookType = BookFactory.getBookType((Book)info.GetValue("BookType", typeof(Book)));
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("BookID", BookID);
            info.AddValue("Status", Status);
            info.AddValue("Availability", Availability);
            info.AddValue("BookType", BookType);
        }
        #endregion
    }
}
