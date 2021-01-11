namespace Project
{
    partial class UserActivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.aBookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.aBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Show_borrowing_books = new System.Windows.Forms.Button();
            this.Borrow_book = new System.Windows.Forms.Button();
            this.Search_book = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aBookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aBookBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBookBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // aBookBindingSource3
            // 
            this.aBookBindingSource3.DataSource = typeof(Project.ABook);
            // 
            // aBookBindingSource1
            // 
            this.aBookBindingSource1.DataSource = typeof(Project.ABook);
            // 
            // aBookBindingSource
            // 
            this.aBookBindingSource.DataSource = typeof(Project.ABook);
            // 
            // Show_borrowing_books
            // 
            this.Show_borrowing_books.Location = new System.Drawing.Point(1011, 149);
            this.Show_borrowing_books.Name = "Show_borrowing_books";
            this.Show_borrowing_books.Size = new System.Drawing.Size(96, 51);
            this.Show_borrowing_books.TabIndex = 1;
            this.Show_borrowing_books.Text = "Sách đang mượn";
            this.Show_borrowing_books.UseVisualStyleBackColor = true;
            this.Show_borrowing_books.Click += new System.EventHandler(this.Show_borrowing_books_Click);
            // 
            // Borrow_book
            // 
            this.Borrow_book.Location = new System.Drawing.Point(1011, 277);
            this.Borrow_book.Name = "Borrow_book";
            this.Borrow_book.Size = new System.Drawing.Size(96, 51);
            this.Borrow_book.TabIndex = 2;
            this.Borrow_book.Text = "Mượn sách";
            this.Borrow_book.UseVisualStyleBackColor = true;
            // 
            // Search_book
            // 
            this.Search_book.Location = new System.Drawing.Point(1011, 90);
            this.Search_book.Name = "Search_book";
            this.Search_book.Size = new System.Drawing.Size(96, 40);
            this.Search_book.TabIndex = 3;
            this.Search_book.Text = "Tìm";
            this.Search_book.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 40);
            this.textBox1.TabIndex = 4;
            // 
            // aBookBindingSource2
            // 
            this.aBookBindingSource2.DataSource = typeof(Project.ABook);
            // 
            // aBookBindingSource4
            // 
            this.aBookBindingSource4.DataSource = typeof(Project.ABook);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Project.User);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Project.Book);
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataSource = typeof(Project.Book);
            // 
            // bookBindingSource2
            // 
            this.bookBindingSource2.DataSource = typeof(Project.Book);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.ISBN,
            this.Status,
            this.Availability,
            this.BookID});
            this.dataGridView1.DataSource = this.aBookBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(93, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 179);
            this.dataGridView1.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 125;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Availability";
            this.Availability.MinimumWidth = 6;
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            this.Availability.Width = 125;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 125;
            // 
            // aBookBindingSource5
            // 
            this.aBookBindingSource5.DataSource = typeof(Project.ABook);
            // 
            // bookBindingSource3
            // 
            this.bookBindingSource3.DataSource = typeof(Project.Book);
            // 
            // UserActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search_book);
            this.Controls.Add(this.Borrow_book);
            this.Controls.Add(this.Show_borrowing_books);
            this.Name = "UserActivity";
            this.Text = "GridViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBookBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource aBookBindingSource;
        private System.Windows.Forms.BindingSource aBookBindingSource1;
        private System.Windows.Forms.Button Show_borrowing_books;
        private System.Windows.Forms.Button Borrow_book;
        private System.Windows.Forms.Button Search_book;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource aBookBindingSource2;
        private System.Windows.Forms.BindingSource aBookBindingSource3;
        private System.Windows.Forms.BindingSource aBookBindingSource4;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.BindingSource bookBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aBookBindingSource5;
        private System.Windows.Forms.BindingSource bookBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
    }
}