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
        static XmlNode root;
        static XmlNode xn; XmlDocument xdoc;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register(object sender, EventArgs e)
        {
            // Lưu các thông tin vào xml file 
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            label8.Hide();
            department_txt.Hide();
        }
    }
}
