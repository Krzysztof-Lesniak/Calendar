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
        public void AddTaskFromMemory(DateTime dateOfTask)
        {
            var numberOfSameDateTasks = CalendarDb.CalendarTasks.Count(x => x.Date == dateOfTask);
            List<CalendarTask> newList = CalendarDb.CalendarTasks.Where(p => p.Date == dateOfTask).ToList();
            foreach (var task in newList)
            {
                checkedListBox1.Items.Add(task.Title);
            }
        }
        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            checkedListBox1.Tag = 1; checkedListBox1.SelectedIndex = 0;
        }
    }
}
