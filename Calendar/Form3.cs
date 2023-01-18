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
            if (CalendarDbDecorator.IfUserExists(NewUserUsername_TextBox.Text))
            {
                var rand = new Random();
                var randomName = "Fred" + rand.Next().ToString();
                var result = MessageBox.Show("this username is aleready taken. \nTry something else, maybe" + randomName + " ?", "username occupied", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (result == DialogResult.OK)
                {
                    NewUserUsername_TextBox.Text = randomName;
                } else NewUserUsername_TextBox.Text = "";
            }
            else
            {


                if (NewUserPassword_TextBox.Text != RepeatPassword_Textbox.Text)
                {
                    MessageBox.Show("repeted password is different then original one! Please try again.",
                         "incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    NewUserPassword_TextBox.Clear();
                    RepeatPassword_Textbox.Clear();
                    return;
                }

                if (Hirer_checkBox.Checked)
                {
                    CalendarDbDecorator.AddUser(NewUserUsername_TextBox.Text, NewUserPassword_TextBox.Text, role.hirer);
                }
                else if (Specialist_CheckBox.Checked)
                {
                    CalendarDbDecorator.AddUser(NewUserUsername_TextBox.Text, NewUserPassword_TextBox.Text, role.specialist);
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
