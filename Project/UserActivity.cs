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
    public partial class UserActivity : Form
    {

        
        public UserActivity()
        {
            InitializeComponent();
        }
        Database database = Database.GetDatabase();
        //Load xml

        private void Show_borrowing_books_Click(object sender, EventArgs e)
        {
            List<ABook> list_borrowed_books = database.listBook.FindAll(item => LoginForm.user.Acc.no_borrowed_books.Contains(item.BookID));
            foreach (ABook book in list_borrowed_books)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = book.BookType.Title;
                row.Cells[1].Value = book.BookType.Author;
                row.Cells[2].Value = book.BookType.ISBN;
                row.Cells[3].Value = book.Status;
                row.Cells[4].Value = book.Availability;
                row.Cells[5].Value = book.BookID;
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
