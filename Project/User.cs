using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    [Serializable]
    public class User
    {
        public User()
        {

        }
        public User(string Username, string ID,string Email,DateTime DateofBirth,string PhoneNum)
        {
            this._Username = Username;
            this._ID = ID;
            this._Email = Email;
            this._DateofBirth = DateofBirth;
            this._PhoneNum = PhoneNum;
        }

        private string _Username;
        private string _ID;
        private string _Email;
        private DateTime _DateofBirth;
        private string _PhoneNum;
        private Account _Acc=new Account();
        public Account Acc
        {
            get { return _Acc; }
            set { _Acc = value; }
        }
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
        public static bool CheckPassword(string input)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            return hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum8Chars.IsMatch(input);
        }
        public static bool CheckDateofBirth(DateTime d)
        {
            return d.Year < 2003;
        }
        public static bool CheckPhoneNumber(string phone)
        {
            string regex1 = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9] 
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
            Regex re1 = new Regex(regex1);
            return re1.IsMatch(phone);
        }
    }
}
