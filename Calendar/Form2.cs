﻿using Calendar.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewUser_button_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            if (CalendarDbDecorator.Users.Any(x => x._userName == username_textBox.Text))
            {
                var user = CalendarDbDecorator.Users.
                    Find(x => x._userName == username_textBox.Text);
                if (user._password == password_textBox.Text)
                {
                    new Form1(user).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username_textBox.Clear();
                    password_textBox.Clear();
                }
                
            }
            else
            {
                
                MessageBox.Show("there is no user with that username", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username_textBox.Clear();
                password_textBox.Clear();
            }
        }
    }
}
