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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       
        private void login(object sender, EventArgs e)
        {
            string username = UserID.Text;
            string password = Password.Text;
        }
        public static bool IsValidLogin(string user, string password)
        {
            XDocument doc = XDocument.Load("users.xml");
            return false;
        }
        private void open_register(object sender, EventArgs e) 
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }           
    }
}
