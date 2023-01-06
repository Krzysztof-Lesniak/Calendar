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
    public partial class UserControlDays : UserControl
    {

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void lbDays_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }

        public void days(int numday)
        {
            lbDays.Text = numday.ToString();
            
        }

        public void AddTask(string text)
        {
            checkedListBox1.Items.Add(text);
        }


        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
