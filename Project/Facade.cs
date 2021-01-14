using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Facade
    {
        public Facade(string E, string P, DateTime d)
        {
            Email = E;
            PhoneNum = P;
            DateofBirth = d;

        }
        string Email;
        string PhoneNum;
        DateTime DateofBirth;
        public string Check()
        {
            string check="";
            if (!User.CheckDateofBirth(DateofBirth)) check += "Không có sinh viên nào sinh sau 2003,làm ơn nhập lại!\n";
            if (!User.CheckPhoneNumber(PhoneNum)) check += "Số điện thoại không phù hợp!\n";
            if (!Librarian.check_Email(Email)) check += "Email không phù hợp!";
            return check;
        }
    }
    }
}
