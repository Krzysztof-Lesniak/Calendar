using Calendar.Database;
using Calendar.Models;
using System.Globalization;
using System.Security.Cryptography;

namespace Calendar
{
    public partial class Form1 : Form
    {
        
        int month, year;
        int daysInMonth;

        List<UserControlDays> daysList = new List<UserControlDays>();
        UserControlUI uI = new UserControlUI();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            DisplayDays();
            DisplayUI();
        }
        void DisplayUI()
        {
            uI.comboBoxDays.Items.Clear();
            UI_container.Controls.Add(uI);
            for (int i = 1; i <= daysInMonth; i++)
            {
                uI.comboBoxDays.Items.Add(i);
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
                
                if (CalendarDb.CalendarTasks.Any(x => x.Date == new DateTime(year,month,i)))
                {
                    ucdays.AddTaskFromMemory(GetTheExistingTaskDate(i));
                }
                else if (Convert.ToInt32(uI.comboBoxDays.SelectedItem) == i 
                    && !String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    ucdays.AddTask(textBox1.Text);
                }

                day_container.Controls.Add((ucdays));
                daysList.Add(ucdays); // to jeszcze nie wiadomo po co w ogóle istnieje

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
            daysList.Clear();
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
            daysList.Clear();
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
            var dateString = Convert.ToString(uI.comboBoxDays.SelectedItem) + '/' + Convert.ToString(month) + '/' + Convert.ToString(year);
            var newCalendarTask = new CalendarTask(0, textBox1.Text, DateTime.Parse(dateString)); // to do typie
            //todo add task to task list - separate method
            CalendarDb.CalendarTasks.Add(newCalendarTask);
            day_container.Controls.Clear();
            DisplayDays();
            textBox1.Text = "";

            }
            
        }
        
        private DateTime GetTheExistingTaskDate (int dayNumber)
        {
            return CalendarDb.CalendarTasks.Find(x => x.Date == new DateTime(year, month, dayNumber)).Date;
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

        private void loadButton_Click(object sender, EventArgs e)
        {
            day_container.Controls.Clear();
            UI_container.Controls.Clear();
            CalendarDb.Load(Convert.ToInt32(Calendar_ComboBox.SelectedItem));
            DisplayDays();
            DisplayUI();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            day_container.Controls.Clear();
            UI_container.Controls.Clear();
            CalendarDb.CalendarTasks.Clear();
            daysList.Clear();
            DisplayDays();
            DisplayUI();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Calendar_ComboBox.Items.Clear();
            CalendarDb.save();
            for (int i = 0; i < CalendarDb.calLp; i++)
            {
                Calendar_ComboBox.Items.Add(i + 1);
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}