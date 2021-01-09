using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        public User(string Username, string Password)
        {
            this._Username = Username;
            this._Password = Password;
        }

        private string _Username;
        private Account acc=new Account();

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
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
            return d.Year > 2003;
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
