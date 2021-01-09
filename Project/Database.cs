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
        private Database() { }
        public void saveDatabase()
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(Database));
            using (Stream fs = new FileStream("Serialized.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                x.Serialize(fs, _db);
            }
        }
        private static Database _db;
        public static Database GetDatabase()
        {
            if (_db == null)
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(Database));
                // Khởi tạo 3 bảng (tùy m sửa )
                using (XmlTextReader textReader = new XmlTextReader("Serialized.xml"))
                {
                   _db=((Database)x.Deserialize(textReader));
                }

            }
            return _db;
        }


        private List<Book> list = new List<Book>();

        public List<User> users = new List<User>();
        public bool CheckAccount(string user)
        {
            return users.Any(item => item.Username == user);
        }
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
