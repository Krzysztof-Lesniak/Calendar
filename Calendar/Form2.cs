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

        private void button1_Click(object sender, EventArgs e)
        {

            if (username_textBox.Text == "persidal" && password_textBox.Text == "a")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username or password","Try again",MessageBoxButtons.OK,MessageBoxIcon.Error);
                username_textBox.Clear();
                password_textBox.Clear();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
