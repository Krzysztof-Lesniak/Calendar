using Calendar.Database;
using Calendar.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Security.Cryptography;

namespace Calendar
{
    public partial class CalendarForm : Form
    {
        private User _logedInUser;
        private UserControlUI uI = new UserControlUI();
        private bool _isLoaded;
        public CalendarForm(User logedInUser)
        {
            InitializeComponent();
            _logedInUser= logedInUser;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if(_logedInUser.Role == role.specialist)
            {
                textBox1.Hide();
                buttonAddTask.Hide();
            }
            
            DisplayDays();
            DisplayUI();
            foreach (var calendars in CalendarDbDecorator.GetAllCalendarObjects())
            {
                Calendar_ComboBox.Items.Add(calendars.Name);
            }
        }
        void DisplayUI()
        {
            if(_logedInUser.Role == role.hirer)
            {
                uI.comboBoxDays.Items.Clear();
                UI_container.Controls.Add(uI);
                for (int i = 1; i <= CalendarLogic.daysInMonth; i++)
                {
                    uI.comboBoxDays.Items.Add(i);
                }
            }
        }
        void DisplayDays()
        {
            var startingDay = CalendarLogic.GetNumberOfStartingDayOfTheWeek();
            for (int i = 0; i <startingDay; i++)
            {
                UserControlBlanc ucblanc = new UserControlBlanc();
                day_container.Controls.Add(ucblanc);
            }

            var numberOfDays = CalendarLogic.daysInMonth;
            for (int i = 1; i <= numberOfDays ; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);

                var tempDate = new DateTime(CalendarLogic.year, CalendarLogic.month, i);
                if (CalendarLogic.currentCalendar.TaskList.Any(x => x.Date == tempDate))
                {
                    var thisDate = new DateTime(CalendarLogic.year, CalendarLogic.month, i);
                    var existingTaskDate = CalendarLogic.currentCalendar.TaskList.Find(x => x.Date == thisDate).Date;

                    ucdays.AddTaskFromMemory(existingTaskDate, CalendarLogic.currentCalendar);
                }
                else if (Convert.ToInt32(uI.comboBoxDays.SelectedItem) == i 
                    && !String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    ucdays.AddTask(textBox1.Text);
                }
                day_container.Controls.Add((ucdays));
            }

            DateLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(CalendarLogic.month) + " " + CalendarLogic.year;
        }

        private void next_month_Click(object sender, EventArgs e)
        {
            day_container.Controls.Clear();
            UI_container.Controls.Clear();

            CalendarLogic.NextMonthChange();

            DisplayDays();
            DisplayUI();
        }
        private void previous_month_Click(object sender, EventArgs e)
        {
            day_container.Controls.Clear();
            UI_container.Controls.Clear();
            
            CalendarLogic.PrevMonthChange();

            DisplayDays();
            DisplayUI();
        }
        
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            
            if (uI.comboBoxDays.SelectedItem == null || String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("you have to choose a date, and provide the task name", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var taskTextString = Convert.ToString(uI.comboBoxDays.SelectedItem);
                CalendarLogic.AddTask(taskTextString, textBox1.Text);
                textBox1.Text = "";
                day_container.Controls.Clear();
                DisplayDays();
            }
        }
        
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (Calendar_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("you have to choose a calendar you want to load", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var calendarName = Calendar_ComboBox.SelectedItem.ToString();
                
                CalendarLogic.currentCalendar = CalendarDbDecorator.Load(calendarName);
                day_container.Controls.Clear();
                UI_container.Controls.Clear();
                DisplayDays();
                DisplayUI();
                CalendarName_TextBox.Text = calendarName;
                Calendar_ComboBox.SelectedItem = null;
                _isLoaded= true;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (CalendarName_TextBox != null
                && !string.IsNullOrWhiteSpace(CalendarName_TextBox.Text)
                && !CalendarDbDecorator.IsCalendarIdUsed(CalendarLogic.currentCalendar.Id))
            {
                CalendarLogic.currentCalendar.Name = CalendarName_TextBox.Text;
                CalendarDbDecorator.Save(CalendarLogic.currentCalendar);

                Calendar_ComboBox.Items.Clear();

                foreach (var calendars in CalendarDbDecorator.GetAllCalendarObjects())
                {
                    Calendar_ComboBox.Items.Add(calendars.Name);
                }
                CalendarName_TextBox.Clear();
                day_container.Controls.Clear();
                UI_container.Controls.Clear();
                CalendarLogic.currentCalendar = new CalendarObj();
                DisplayDays();
                DisplayUI();
                _isLoaded = false;
            }
            else if (_isLoaded && (!string.IsNullOrWhiteSpace(CalendarName_TextBox.Text)))
            {

                CalendarDbDecorator.Update(CalendarLogic.currentCalendar);

                day_container.Controls.Clear();
                UI_container.Controls.Clear();
                DisplayDays();
                DisplayUI();
                _isLoaded = false;

            }
            else
            {
                MessageBox.Show("please provide valid name for the calendar", "insufissient namme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Calendar_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("you have to choose a calendar you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var calendarName = Calendar_ComboBox.SelectedItem.ToString();
                CalendarDbDecorator.Delete(calendarName);
                Calendar_ComboBox.Items.Remove(Calendar_ComboBox.SelectedItem);
                day_container.Controls.Clear();
                UI_container.Controls.Clear();
                DisplayDays();
                DisplayUI();
            }
        }
        private void CloseAndSave_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logOut_button_Click(object sender, EventArgs e)
        {
            
            
            new Form2().Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}