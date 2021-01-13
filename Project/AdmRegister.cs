using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdmRegister : Form
    {
        Database database = Database.GetDatabase();
        public AdmRegister()
        {
            InitializeComponent();
        }
        
        private void Register_Click(object sender, EventArgs e)
        {
            string Check = "";
            if (database.CheckAccount(Account.Text)) Check += "Account đã tồn tại!\n";
            if (!User.CheckPassword(Password.Text)) Check += "Password phải có ít nhất 8 kí tự, có số và có kí tự viết hoa!\n";
            if (!User.CheckDateofBirth(DateofBirth.Value)) Check += "Không có sinh viên nào sinh sau 2003,làm ơn nhập lại!\n";
            if (!User.CheckPhoneNumber(PhoneNum.Text)) Check += "Số điện thoại không phù hợp!\n";
            if (!Librarian.check_Email(Email.Text)) Check += "Email không phù hợp!";
            if (Manegement_Code.Text != "HungNguyenTai") Check += "Sai Mã Quản lý!";
            if (Check != "")
            {
                MessageBox.Show(Check);
                return;
            }
            database.librarians.Add(new Librarian(Account.Text,HoVaTen.Text,Password.Text,Home_Address.Text,Email.Text,PhoneNum.Text));
            database.saveDatabase();
            this.Close();
            // Lưu các thông tin vào xml file 
        }
    }
}
