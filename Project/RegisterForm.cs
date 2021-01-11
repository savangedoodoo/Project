using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Project
{
    public partial class RegisterForm : Form
    {
        static string ID = string.Empty;
        static string name = string.Empty;
        static string pswd = string.Empty;
        static string age = string.Empty;
        static string mobile = string.Empty;
        static string position = string.Empty;
        static string department = string.Empty;
        public RegisterForm()
        {
            InitializeComponent();
        }
        Database database = Database.GetDatabase();
        private void register(object sender, EventArgs e)
        {
            string Check = "";
            if(database.CheckAccount(Account.Text)) Check+="Account đã tồn tại!\n";
            if (!User.CheckPassword(Password.Text)) Check += "Password phải có ít nhất 8 kí tự, có số và có kí tự viết hoa!\n";
            if (!User.CheckDateofBirth(DateofBirth.Value)) Check += "Không có sinh viên nào sinh sau 2003,làm ơn nhập lại!\n";
            if (!User.CheckPhoneNumber(PhoneNum.Text)) Check += "Số điện thoại không phù hợp!\n";
            if(Check!="")
            {
                MessageBox.Show(Check);
                return;
            }
            database.users.Add(new User(Account.Text, Password.Text));
            database.saveDatabase();
            this.Close();
            // Lưu các thông tin vào xml file 
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            label8.Hide();
            department_txt.Hide();
        }
    }
}
