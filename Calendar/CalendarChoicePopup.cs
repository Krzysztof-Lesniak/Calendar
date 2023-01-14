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
    public partial class CalendarChoicePopup : Form
    {
        public ComboBox comboBox1;

        public CalendarChoicePopup()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CalendarChoicePopup
            // 
            this.ClientSize = new System.Drawing.Size(148, 253);
            this.Controls.Add(this.comboBox1);
            this.Name = "CalendarChoicePopup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CalendarChoicePopup_Load);
            this.ResumeLayout(false);

        }

        private void CalendarChoicePopup_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
