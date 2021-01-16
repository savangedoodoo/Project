﻿using System;
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
            if(database.CheckAccount(IDname.Text)) Check+="ID đã tồn tại!\n";
            if (!CLibrarian_001.check_Email(Email.Text)) Check += "Email không phù hợp!";
            if (!User.CheckDateofBirth(DateofBirth.Value)) Check += "Không có sinh viên nào sinh sau 2003,làm ơn nhập lại!\n";
            if (!User.CheckPhoneNumber(PhoneNum.Text)) Check += "Số điện thoại không phù hợp!\n";
            Facade check = new Facade(Email.Text, PhoneNum.Text, DateofBirth.Value);
            Check += check.Check();
            if (Check!="")
            {
                MessageBox.Show(Check);
                return;
            }
            database.users.Add(new User(HoVaTen.Text, IDname.Text,Email.Text,DateofBirth.Value,PhoneNum.Text));
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
