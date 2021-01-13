namespace Project
{
    partial class UserManegement
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
            this.Add_User = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_User
            // 
            this.Add_User.Location = new System.Drawing.Point(53, 73);
            this.Add_User.Name = "Add_User";
            this.Add_User.Size = new System.Drawing.Size(141, 40);
            this.Add_User.TabIndex = 0;
            this.Add_User.Text = "Thêm người dùng";
            this.Add_User.UseVisualStyleBackColor = true;
            this.Add_User.Click += new System.EventHandler(this.Add_User_Click);
            // 
            // UserManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_User);
            this.Name = "UserManegement";
            this.Text = "UserManegement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_User;
    }
}