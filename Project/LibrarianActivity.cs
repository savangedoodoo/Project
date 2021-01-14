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
        Book BookType;
        private void Addbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addBook= new AddBook();
            addBook.Closed += (s, args) => this.Show();
            addBook.Closed += (s, args) => database.saveDatabase();
            addBook.Show();
        }

        private void Search_Book_Click(object sender, EventArgs e)
        {
            if (BookFactory.Contain(Search_ISBN.Text))
            {
                BookType = BookFactory.getBookType(Search_ISBN.Text);
                Delete.Enabled = true;
                Update.Enabled = true;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                BookType.Title = Title.Text;
                BookType.Author = Title.Text;
                BookType.Publisher = Publisher.Text;
                BookType.Year = Convert.ToInt32(Year.Text);
            }
            catch
            {
                MessageBox.Show("Nhập không hợp lệ!");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //xóa các sách nối tới đầu sách
            database.listBook.RemoveAll(item => item.BookType.ISBN == BookType.ISBN);
            BookFactory.Remove(BookType.ISBN);
            Delete.Enabled = false;
            Update.Enabled = false;
        }

        private void Delete_Book_Click(object sender, EventArgs e)
        {
            try
            {
                database.listBook.RemoveAll(item => item.BookID == Delete_Book.Text);
            }
            catch
            {
                MessageBox.Show("Không có BookID cần xóa!");
            }
        }
    }
}
