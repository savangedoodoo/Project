using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;


namespace Project
{
    [Serializable]
    public class User:CPerson_002
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
        public User Clone()

        {

            using (MemoryStream stream = new MemoryStream())

            {

                if (this.GetType().IsSerializable)

                {

                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(stream, this);

                    stream.Position = 0;

                    return (User)formatter.Deserialize(stream);

                }

                return null;

            }
        }
        private Account _Acc=new Account();
        public Account Acc
        {
            get { return _Acc; }
            set { _Acc = value; }
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
