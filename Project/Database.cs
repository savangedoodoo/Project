using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Database
    {
        private Database()
        {

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
