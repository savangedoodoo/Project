using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project
{
    class Database
    {
        private Database()
        {
            // Khởi tạo 3 bảng (tùy m sửa )
            XmlTextReader textReader1 = new XmlTextReader("C:\\users.xml");
            XmlTextReader textReader2 = new XmlTextReader("C:\\books.xml");
            XmlTextReader textReader3 = new XmlTextReader("C:\\abooks.xml");
            XmlTextReader textReader4 = new XmlTextReader("C:\\abooks.xml");
        }
        private static Database _db;
        public static Database GetDatabase()
        {
            if (_db == null)
            {
                _db = new Database();
            }
            return _db;
        }
        private List<Book> list;

        public void sortYear()
        {
            list.Sort((IComparer<Book>)Book.sortYear());
        }
        public void sortauthor()
        {
            list.Sort((IComparer<Book>)Book.sortauthor());
        }
        public void Sort()
        {
            list.Sort();
        }
        // end Book list
    }
}
