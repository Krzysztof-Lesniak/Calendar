namespace Calendar
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewUserUsername_TextBox = new System.Windows.Forms.TextBox();
            this.CreateNewUser_button = new System.Windows.Forms.Button();
            this.NewUserPassword_TextBox = new System.Windows.Forms.TextBox();
            this.RepeatPassword_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GoBack_button = new System.Windows.Forms.Button();
            this.Hirer_checkBox = new System.Windows.Forms.CheckBox();
            this.Specialist_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NewUserUsername_TextBox
            // 
            this.NewUserUsername_TextBox.Location = new System.Drawing.Point(60, 92);
            this.NewUserUsername_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewUserUsername_TextBox.Name = "NewUserUsername_TextBox";
            this.NewUserUsername_TextBox.Size = new System.Drawing.Size(173, 23);
            this.NewUserUsername_TextBox.TabIndex = 0;
            this.NewUserUsername_TextBox.TextChanged += new System.EventHandler(this.NewUserUsername_TextBox_TextChanged);
            // 
            // CreateNewUser_button
            // 
            this.CreateNewUser_button.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateNewUser_button.Location = new System.Drawing.Point(60, 239);
            this.CreateNewUser_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewUser_button.Name = "CreateNewUser_button";
            this.CreateNewUser_button.Size = new System.Drawing.Size(172, 34);
            this.CreateNewUser_button.TabIndex = 1;
            this.CreateNewUser_button.Text = "Create User";
            this.CreateNewUser_button.UseVisualStyleBackColor = true;
            this.CreateNewUser_button.Click += new System.EventHandler(this.CreateNewUser_button_Click);
            // 
            // NewUserPassword_TextBox
            // 
            this.NewUserPassword_TextBox.Location = new System.Drawing.Point(60, 137);
            this.NewUserPassword_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewUserPassword_TextBox.Name = "NewUserPassword_TextBox";
            this.NewUserPassword_TextBox.Size = new System.Drawing.Size(173, 23);
            this.NewUserPassword_TextBox.TabIndex = 2;
            // 
            // RepeatPassword_Textbox
            // 
            this.RepeatPassword_Textbox.Location = new System.Drawing.Point(60, 184);
            this.RepeatPassword_Textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepeatPassword_Textbox.Name = "RepeatPassword_Textbox";
            this.RepeatPassword_Textbox.Size = new System.Drawing.Size(173, 23);
            this.RepeatPassword_Textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "NEW USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repeat password";
            // 
            // GoBack_button
            // 
            this.GoBack_button.Location = new System.Drawing.Point(237, 9);
            this.GoBack_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBack_button.Name = "GoBack_button";
            this.GoBack_button.Size = new System.Drawing.Size(52, 24);
            this.GoBack_button.TabIndex = 8;
            this.GoBack_button.Text = "back";
            this.GoBack_button.UseVisualStyleBackColor = true;
            this.GoBack_button.Click += new System.EventHandler(this.GoBack_button_Click);
            // 
            // Hirer_checkBox
            // 
            this.Hirer_checkBox.AutoSize = true;
            this.Hirer_checkBox.Checked = true;
            this.Hirer_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Hirer_checkBox.Location = new System.Drawing.Point(60, 217);
            this.Hirer_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hirer_checkBox.Name = "Hirer_checkBox";
            this.Hirer_checkBox.Size = new System.Drawing.Size(52, 19);
            this.Hirer_checkBox.TabIndex = 9;
            this.Hirer_checkBox.Text = "Hirer";
            this.Hirer_checkBox.UseVisualStyleBackColor = true;
            this.Hirer_checkBox.CheckedChanged += new System.EventHandler(this.Hirer_checkBox_CheckedChanged);
            // 
            // Specialist_CheckBox
            // 
            this.Specialist_CheckBox.AutoSize = true;
            this.Specialist_CheckBox.Location = new System.Drawing.Point(122, 217);
            this.Specialist_CheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Specialist_CheckBox.Name = "Specialist_CheckBox";
            this.Specialist_CheckBox.Size = new System.Drawing.Size(75, 19);
            this.Specialist_CheckBox.TabIndex = 10;
            this.Specialist_CheckBox.Text = "Specialist";
            this.Specialist_CheckBox.UseVisualStyleBackColor = true;
            this.Specialist_CheckBox.CheckedChanged += new System.EventHandler(this.Specialist_CheckBox_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 338);
            this.Controls.Add(this.Specialist_CheckBox);
            this.Controls.Add(this.Hirer_checkBox);
            this.Controls.Add(this.GoBack_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepeatPassword_Textbox);
            this.Controls.Add(this.NewUserPassword_TextBox);
            this.Controls.Add(this.CreateNewUser_button);
            this.Controls.Add(this.NewUserUsername_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NewUserUsername_TextBox;
        private Button CreateNewUser_button;
        private TextBox NewUserPassword_TextBox;
        private TextBox RepeatPassword_Textbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button GoBack_button;
        private CheckBox Hirer_checkBox;
        private CheckBox Specialist_CheckBox;
    }
}