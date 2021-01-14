using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project
{

    public class Database
    {
        private Database() 
        {
            System.Xml.Serialization.XmlSerializer x1 = new System.Xml.Serialization.XmlSerializer(typeof(List<ABook>));
            using (XmlTextReader textReader = new XmlTextReader("Books.xml"))
            {
                this.listBook = ((List<ABook>)x1.Deserialize(textReader));
            }
            foreach(ABook book in listBook)
            {
                book.BookType = BookFactory.getBookType(book.BookType);
            }    
            System.Xml.Serialization.XmlSerializer x2 = new System.Xml.Serialization.XmlSerializer(typeof(List<User>));
            using (XmlTextReader textReader = new XmlTextReader("Users.xml"))
            {
                this.users = ((List<User>)x2.Deserialize(textReader));
            }
            System.Xml.Serialization.XmlSerializer x3 = new System.Xml.Serialization.XmlSerializer(typeof(List<CLibrarian_001>));
            using (XmlTextReader textReader = new XmlTextReader("Librarians.xml"))
            {
                this.librarians = ((List<CLibrarian_001>)x3.Deserialize(textReader));
            }
        }

        #region Dữ liệu của đối tượng
        public List<ABook> listBook = new List<ABook>();

        public List<User> users = new List<User>();

        public List<CLibrarian_001> librarians = new List<CLibrarian_001>();
        #endregion
        private static Database _db;
        public static Database GetDatabase()
        {
            if (_db == null)
            {
                _db = new Database();
            }
            return _db;
        }
        public void saveDatabase()
        {
            System.Xml.Serialization.XmlSerializer x1 = new System.Xml.Serialization.XmlSerializer(typeof(List<ABook>));
            using (Stream fs = new FileStream("Books.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                x1.Serialize(fs, _db.listBook);
            }
            System.Xml.Serialization.XmlSerializer x2 = new System.Xml.Serialization.XmlSerializer(typeof(List<User>));
            using (Stream fs = new FileStream("Users.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                x2.Serialize(fs, _db.users);
            }
            System.Xml.Serialization.XmlSerializer x3 = new System.Xml.Serialization.XmlSerializer(typeof(List<CLibrarian_001>));
            using (Stream fs = new FileStream("Librarians.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                x3.Serialize(fs, _db.librarians);
            }
        }
        public bool CheckAccount(string user)
        {
            return users.Any(item => item.Username == user);
        }
        // end Book list
    }
}
