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
    public partial class LibrarianActivity : Form
    {
        public LibrarianActivity()
        {
            InitializeComponent();
        }
        Database database = Database.GetDatabase();
        private void Addbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addBook= new AddBook();
            addBook.Closed += (s, args) => this.Show();
            addBook.Closed += (s, args) => database.saveDatabase();
            addBook.Show();
        }
    }
}
