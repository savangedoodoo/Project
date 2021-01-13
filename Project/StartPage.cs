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
    public partial class StartPage: Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Edit_Books_Click(object sender, EventArgs e)
        {
            Open_Form(new LibrarianActivity());
        }

        private void User_Information_Click(object sender, EventArgs e)
        {
            Open_Form(new UserActivity());
        }

        private void Edit_Users_Click(object sender, EventArgs e)
        {
            Open_Form(new UserManegement());

        }

        private void Change_Password_Click(object sender, EventArgs e)
        {
            Open_Form(new ChangePassword());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Open_Form(Form form)
        {
            this.Hide();
            form.Closed += (s, args) => this.Show();
            form.Closed += (s, args) => Database.GetDatabase().saveDatabase();
            form.Show();
        }
    }
}
