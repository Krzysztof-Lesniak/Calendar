﻿namespace Calendar
{
    partial class CalendarForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.day_container = new System.Windows.Forms.FlowLayoutPanel();
            this.next_month = new System.Windows.Forms.Button();
            this.previous_month = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UI_container = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.Calendar_ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.logOut_button = new System.Windows.Forms.Button();
            this.CloseAndSave_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // day_container
            // 
            this.day_container.Location = new System.Drawing.Point(34, 111);
            this.day_container.Name = "day_container";
            this.day_container.Size = new System.Drawing.Size(758, 461);
            this.day_container.TabIndex = 0;
            this.day_container.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // next_month
            // 
            this.next_month.Location = new System.Drawing.Point(698, 591);
            this.next_month.Name = "next_month";
            this.next_month.Size = new System.Drawing.Size(94, 29);
            this.next_month.TabIndex = 0;
            this.next_month.Text = "next";
            this.next_month.UseVisualStyleBackColor = true;
            this.next_month.Click += new System.EventHandler(this.next_month_Click);
            // 
            // previous_month
            // 
            this.previous_month.Location = new System.Drawing.Point(590, 591);
            this.previous_month.Name = "previous_month";
            this.previous_month.Size = new System.Drawing.Size(94, 29);
            this.previous_month.TabIndex = 1;
            this.previous_month.Text = "previous";
            this.previous_month.UseVisualStyleBackColor = true;
            this.previous_month.Click += new System.EventHandler(this.previous_month_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sunday";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(590, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Friday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(480, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thursday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(341, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(233, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tuesday";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(133, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Monday";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(686, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Saturday";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(341, 24);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(139, 28);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "MONTH YEAR";
            this.DateLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Calendar.CalendarForm);
            // 
            // UI_container
            // 
            this.UI_container.Location = new System.Drawing.Point(811, 111);
            this.UI_container.Name = "UI_container";
            this.UI_container.Size = new System.Drawing.Size(234, 97);
            this.UI_container.TabIndex = 10;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(811, 260);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(234, 27);
            this.buttonAddTask.TabIndex = 11;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(811, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(811, 316);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(111, 56);
            this.save_button.TabIndex = 13;
            this.save_button.Text = "Save this calendar";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(823, 453);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(99, 56);
            this.loadButton.TabIndex = 14;
            this.loadButton.Text = "Load calendar";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(823, 516);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 56);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete calendar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Calendar_ComboBox
            // 
            this.Calendar_ComboBox.FormattingEnabled = true;
            this.Calendar_ComboBox.Location = new System.Drawing.Point(811, 420);
            this.Calendar_ComboBox.Name = "Calendar_ComboBox";
            this.Calendar_ComboBox.Size = new System.Drawing.Size(117, 28);
            this.Calendar_ComboBox.TabIndex = 17;
            this.Calendar_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(811, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "choose calendar";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // logOut_button
            // 
            this.logOut_button.Location = new System.Drawing.Point(1056, 12);
            this.logOut_button.Name = "logOut_button";
            this.logOut_button.Size = new System.Drawing.Size(91, 29);
            this.logOut_button.TabIndex = 21;
            this.logOut_button.Text = "log out";
            this.logOut_button.UseVisualStyleBackColor = true;
            this.logOut_button.Click += new System.EventHandler(this.logOut_button_Click);
            // 
            // CloseAndSave_button
            // 
            this.CloseAndSave_button.Location = new System.Drawing.Point(929, 12);
            this.CloseAndSave_button.Name = "CloseAndSave_button";
            this.CloseAndSave_button.Size = new System.Drawing.Size(116, 29);
            this.CloseAndSave_button.TabIndex = 22;
            this.CloseAndSave_button.Text = "save and close";
            this.CloseAndSave_button.UseVisualStyleBackColor = true;
            this.CloseAndSave_button.Click += new System.EventHandler(this.CloseAndSave_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1159, 647);
            this.Controls.Add(this.CloseAndSave_button);
            this.Controls.Add(this.logOut_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Calendar_ComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.UI_container);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previous_month);
            this.Controls.Add(this.next_month);
            this.Controls.Add(this.day_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel day_container;
        private Button next_month;
        private Button previous_month;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label DateLabel;
        private BindingSource form1BindingSource;
        private FlowLayoutPanel UI_container;
        private Button buttonAddTask;
        private TextBox textBox1;
        private Button save_button;
        private Button loadButton;
        private Button deleteButton;
        private ComboBox Calendar_ComboBox;
        private Label label8;
        private Button logOut_button;
        private Button CloseAndSave_button;
    }
}