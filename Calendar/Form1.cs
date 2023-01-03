namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        void DisplayDays()
        {
            var now = DateTime.Now;
            var startOfTheMonth = new DateTime(now.Year, now.Month, 1);
            var daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            int dayOfTheMonth = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}