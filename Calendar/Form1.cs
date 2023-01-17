using Calendar.Database;
using Calendar.Models;
using System.Globalization;
using System.Security.Cryptography;

namespace Calendar
{
    public partial class Form1 : Form
    {
        private User _logedInUser;
        int month, year;
        int daysInMonth;
        bool isLoaded = false;
        UserControlUI uI = new UserControlUI();
        public Form1(User logedInUser)
        {
            InitializeComponent();
            _logedInUser= logedInUser;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            if(_logedInUser._role == role.specialist)
            {
                textBox1.Hide();
                buttonAddTask.Hide();
            }
            DisplayDays();
            DisplayUI();
        }
        void DisplayUI()
        {
            if(_logedInUser._role == role.hirer)
            {
                uI.comboBoxDays.Items.Clear();
                UI_container.Controls.Add(uI);
                for (int i = 1; i <= daysInMonth; i++)
                {
                    uI.comboBoxDays.Items.Add(i);
                }
            }
            

        }
        void DisplayDays()
        {
            var startOfTheMonth = new DateTime(year, month, 1);
            daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            for (int i = 0; i < dayOfTheWeek; i++)
            {
                UserControlBlanc ucblanc = new UserControlBlanc();
                day_container.Controls.Add(ucblanc);
            }

            for (int i = 1; i <= daysInMonth ; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                
                if (CalendarDbDecorator.CalendarTasks.Any(x => x.Date == new DateTime(year,month,i)))
                {
                    ucdays.AddTaskFromMemory(GetTheExistingTaskDate(i));
                }
                else if (Convert.ToInt32(uI.comboBoxDays.SelectedItem) == i 
                    && !String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    ucdays.AddTask(textBox1.Text);
                }

                day_container.Controls.Add((ucdays));

            }
            
            SetYearMonth();
        }

        private void next_month_Click(object sender, EventArgs e)
        {
            day_container.Controls.Clear();
            UI_container.Controls.Clear();

            month++;
            if (month == 13) 
            {
                month = 1;
                year++;
            }
            DisplayDays();
            DisplayUI();
        }
        private void previous_month_Click(object sender, EventArgs e)
        {
            day_container.Controls.Clear();
            UI_container.Controls.Clear();
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }
            DisplayDays();
            DisplayUI();
        }
        public void SetYearMonth()
        {
            DateLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) +" "+ year;
        } 
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            
            if (uI.comboBoxDays.SelectedItem == null || String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("you have to choose a date, and provide the task name", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddTask();
                day_container.Controls.Clear();
                DisplayDays();
            }
            
        }
        private void AddTask()
        {
            var dateString = Convert.ToString(uI.comboBoxDays.SelectedItem) + '/' + Convert.ToString(month) + '/' + Convert.ToString(year);
            var newCalendarTask = new CalendarTask(CalendarDbDecorator.taskNr, textBox1.Text, DateTime.Parse(dateString), 0); // to do typie
            CalendarDbDecorator.CalendarTasks.Add(newCalendarTask);
            CalendarDbDecorator.taskNr++;
            textBox1.Text = "";
        }

        private DateTime GetTheExistingTaskDate (int dayNumber)
        {
            return CalendarDbDecorator.CalendarTasks.Find(x => x.Date == new DateTime(year, month, dayNumber)).Date;
        }
        

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (Calendar_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("you have to choose a calendar you want to load", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CalendarDbDecorator.Load(Convert.ToInt32(Calendar_ComboBox.SelectedItem));
                day_container.Controls.Clear();
                UI_container.Controls.Clear();
                DisplayDays();
                DisplayUI();
            }
            isLoaded= true;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Calendar_ComboBox.Items.Clear();
            if (isLoaded) CalendarDbDecorator.save(Convert.ToInt32(Calendar_ComboBox.SelectedItem));
            else CalendarDbDecorator.save();

            foreach (var calendars in CalendarDbDecorator.CalendarObjects)
            {
                Calendar_ComboBox.Items.Add(calendars.Id);
            }
            
            day_container.Controls.Clear();
            UI_container.Controls.Clear();
            CalendarDbDecorator.CalendarTasks.Clear();
            DisplayDays();
            DisplayUI();
            isLoaded= false;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Calendar_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("you have to choose a calendar you want to delete", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                CalendarDbDecorator.Delete(Convert.ToInt32(Calendar_ComboBox.SelectedItem));
                Calendar_ComboBox.Items.Remove(Calendar_ComboBox.SelectedItem);
                day_container.Controls.Clear();
                UI_container.Controls.Clear();
                CalendarDbDecorator.CalendarTasks.Clear();
                DisplayDays();
                DisplayUI();
            }
        }
        private void CloseAndSave_button_Click(object sender, EventArgs e)
        {
            CalendarDbDecorator.SaveEverything();
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