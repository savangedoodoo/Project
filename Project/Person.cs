using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    [Serializable()]
    public abstract class Person
    {
        protected string _Username;
        protected string _ID;
        protected string _Email;
        protected DateTime _DateofBirth;
        protected string _PhoneNum;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public DateTime DateofBirth
        {
            get { return _DateofBirth; }
            set { _DateofBirth = value; }
        }
        public string PhoneNum
        {
            get { return _PhoneNum; }
            set { _PhoneNum = value; }
        }
    }
}
