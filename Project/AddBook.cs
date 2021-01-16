﻿using System;
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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(Year_txt.Text,out int Year))
            {
                MessageBox.Show("Năm bị sai!");
                return;
            }    
            Book b = BookFactory.getBookType(ISBN_txt.Text, Title_txt.Text, Author_txt.Text, Publisher_txt.Text,Convert.ToInt32(Year_txt.Text));
            status s = status.good;
            if (radioButton2.Checked == true) s = status.medium;
            else if (radioButton3.Checked == true) s = status.bad;
            CLibrarian_001.add_abook(BookID_txt.Text, s, true, b);
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
