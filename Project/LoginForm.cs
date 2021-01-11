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
        Database database = Database.GetDatabase();
        public static User user;
        private void login(object sender, EventArgs e)
        {
            string username = UserID.Text;
            string password = Password.Text;
            if (database.users.Any(item => item.Username == username && item.Password == password))
            {
                LoginForm.user = database.users.Find(item => item.Username == username);
                open_user_activity();
            }
        }
        public static bool IsValidLogin(string user, string password)
        {
            XDocument doc = XDocument.Load("users.xml");
            return false;
        }
        private void open_user_activity()
        {
            this.Hide();
            var user_activity = new UserActivity();
            user_activity.Closed += (s, args) => this.Show();
            user_activity.Show();
        }
        private void open_register(object sender, EventArgs e) 
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Show();
            registerForm.Show();
        }           
    }
}
