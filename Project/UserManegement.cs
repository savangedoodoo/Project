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
    public partial class UserManegement : Form
    {
        public UserManegement()
        {
            InitializeComponent();
        }
        Database database = Database.GetDatabase();
        User user;
        private void Add_User_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Show();
            registerForm.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(database.users.Any(item=>item.ID==Search_ID.Text))
            {
                user = database.users.Find(item => item.ID == Search_ID.Text);
                Name.Text = user.Username;
                ID.Text = user.ID;
                Email.Text = user.Email;
                DateofBirth.Value = user.DateofBirth;
                PhoneNum.Text = user.PhoneNum;
                Update.Enabled = true;
                Delete.Enabled = true;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            user.Username = Name.Text;
            user.ID = ID.Text;
            user.Email = Email.Text;
            user.DateofBirth = DateofBirth.Value;
            user.PhoneNum = PhoneNum.Text;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            database.users.Remove(user);
        }
    }
}
