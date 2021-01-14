namespace Project
{
    partial class LibrarianActivity
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
            this.Addbook = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Search_ISBN = new System.Windows.Forms.RichTextBox();
            this.Search_Book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Delete_Book = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Addbook
            // 
            this.Addbook.Location = new System.Drawing.Point(394, 62);
            this.Addbook.Name = "Addbook";
            this.Addbook.Size = new System.Drawing.Size(89, 35);
            this.Addbook.TabIndex = 0;
            this.Addbook.Text = "Thêm sách";
            this.Addbook.UseVisualStyleBackColor = true;
            this.Addbook.Click += new System.EventHandler(this.Addbook_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(95, 331);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(113, 43);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Xóa đầu sách";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search_ISBN
            // 
            this.Search_ISBN.Location = new System.Drawing.Point(172, 62);
            this.Search_ISBN.Name = "Search_ISBN";
            this.Search_ISBN.Size = new System.Drawing.Size(84, 33);
            this.Search_ISBN.TabIndex = 2;
            this.Search_ISBN.Text = "";
            // 
            // Search_Book
            // 
            this.Search_Book.Location = new System.Drawing.Point(281, 62);
            this.Search_Book.Name = "Search_Book";
            this.Search_Book.Size = new System.Drawing.Size(75, 33);
            this.Search_Book.TabIndex = 3;
            this.Search_Book.Text = "Tìm";
            this.Search_Book.UseVisualStyleBackColor = true;
            this.Search_Book.Click += new System.EventHandler(this.Search_Book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Publisher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Year";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(172, 126);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(222, 22);
            this.Title.TabIndex = 12;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(172, 266);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(222, 22);
            this.Year.TabIndex = 16;
            // 
            // Publisher
            // 
            this.Publisher.Location = new System.Drawing.Point(172, 220);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(222, 22);
            this.Publisher.TabIndex = 17;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(172, 168);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(222, 22);
            this.Author.TabIndex = 18;
            // 
            // Update
            // 
            this.Update.Enabled = false;
            this.Update.Location = new System.Drawing.Point(281, 331);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(113, 43);
            this.Update.TabIndex = 20;
            this.Update.Text = "Cập nhật thông tin đầu sách";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nhập BookID";
            // 
            // Delete_Book
            // 
            this.Delete_Book.Location = new System.Drawing.Point(281, 393);
            this.Delete_Book.Name = "Delete_Book";
            this.Delete_Book.Size = new System.Drawing.Size(75, 33);
            this.Delete_Book.TabIndex = 22;
            this.Delete_Book.Text = "Xóa sách";
            this.Delete_Book.UseVisualStyleBackColor = true;
            this.Delete_Book.Click += new System.EventHandler(this.Delete_Book_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(172, 393);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(84, 33);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // LibrarianActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 447);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Delete_Book);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_Book);
            this.Controls.Add(this.Search_ISBN);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Addbook);
            this.Name = "LibrarianActivity";
            this.Text = "LibrarianActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbook;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.RichTextBox Search_ISBN;
        private System.Windows.Forms.Button Search_Book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Publisher;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete_Book;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}