namespace Project
{
    partial class StartPage
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
            this.Edit_Books = new System.Windows.Forms.Button();
            this.User_Information = new System.Windows.Forms.Button();
            this.Edit_Users = new System.Windows.Forms.Button();
            this.Change_Password = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit_Books
            // 
            this.Edit_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Books.Location = new System.Drawing.Point(169, 205);
            this.Edit_Books.Name = "Edit_Books";
            this.Edit_Books.Size = new System.Drawing.Size(189, 96);
            this.Edit_Books.TabIndex = 0;
            this.Edit_Books.Text = "Edit Books";
            this.Edit_Books.UseVisualStyleBackColor = true;
            this.Edit_Books.Click += new System.EventHandler(this.Edit_Books_Click);
            // 
            // User_Information
            // 
            this.User_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Information.Location = new System.Drawing.Point(427, 205);
            this.User_Information.Name = "User_Information";
            this.User_Information.Size = new System.Drawing.Size(189, 96);
            this.User_Information.TabIndex = 1;
            this.User_Information.Text = "User Information";
            this.User_Information.UseVisualStyleBackColor = true;
            this.User_Information.Click += new System.EventHandler(this.User_Information_Click);
            // 
            // Edit_Users
            // 
            this.Edit_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Users.Location = new System.Drawing.Point(687, 205);
            this.Edit_Users.Name = "Edit_Users";
            this.Edit_Users.Size = new System.Drawing.Size(189, 96);
            this.Edit_Users.TabIndex = 2;
            this.Edit_Users.Text = "Edit Users";
            this.Edit_Users.UseVisualStyleBackColor = true;
            this.Edit_Users.Click += new System.EventHandler(this.Edit_Users_Click);
            // 
            // Change_Password
            // 
            this.Change_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Password.Location = new System.Drawing.Point(262, 414);
            this.Change_Password.Name = "Change_Password";
            this.Change_Password.Size = new System.Drawing.Size(206, 29);
            this.Change_Password.TabIndex = 3;
            this.Change_Password.Text = "Change_Password";
            this.Change_Password.UseVisualStyleBackColor = true;
            this.Change_Password.Click += new System.EventHandler(this.Change_Password_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(536, 414);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(210, 29);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Log out";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 568);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Change_Password);
            this.Controls.Add(this.Edit_Users);
            this.Controls.Add(this.User_Information);
            this.Controls.Add(this.Edit_Books);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Edit_Books;
        private System.Windows.Forms.Button User_Information;
        private System.Windows.Forms.Button Edit_Users;
        private System.Windows.Forms.Button Change_Password;
        private System.Windows.Forms.Button Exit;
    }
}