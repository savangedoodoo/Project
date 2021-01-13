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

        private void Add_User_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Show();
            registerForm.Show();
        }
    }
}
