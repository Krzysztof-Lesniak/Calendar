using Calendar.Database;
using Calendar.Models;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void GoBack_button_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Close();
        }
        private void CreateNewUser_button_Click(object sender, EventArgs e)
        {
            if(NewUserPassword_TextBox.Text != RepeatPassword_Textbox.Text)
            {
                MessageBox.Show("repeted password is different then original one! Please try again.",
                    "incorrect password",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                NewUserPassword_TextBox.Clear();
                RepeatPassword_Textbox.Clear();
                return;

            }

            if (Hirer_checkBox.Checked)
            {
                CalendarDbDecorator.Users.
                    Add(new Hirer(NewUserUsername_TextBox.Text,NewUserPassword_TextBox.Text));
            }
            else if(Specialist_CheckBox.Checked)
            {
                CalendarDbDecorator.Users.
                    Add(new Specialist(NewUserUsername_TextBox.Text,NewUserPassword_TextBox.Text));
            }
            else
            {
                MessageBox.Show("you have to chose user type - hirer or specialist", 
                    "choose usertype", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            MessageBox.Show("Succes", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            new Form2().Show();
            this.Close();


        }
        private void NewUserUsername_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hirer_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Specialist_CheckBox.Checked)
            {
                Specialist_CheckBox.CheckState= CheckState.Unchecked;
            }
            else Hirer_checkBox.CheckState = CheckState.Checked;
        }

        private void Specialist_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(Hirer_checkBox.Checked)
            {
                Hirer_checkBox.CheckState= CheckState.Unchecked;
            }
            else Specialist_CheckBox.CheckState = CheckState.Checked;
        }
    }
}
