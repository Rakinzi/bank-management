﻿namespace _66086_Data_Detectives_Project2
{
    partial class StaffControl
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            unpayedbalanceLabel = new Label();
            extrahoursLabel = new Label();
            unpayedhoursLabel = new Label();
            staffidLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            extrahourTextBox = new TextBox();
            normalhourTextBox = new TextBox();
            button2 = new Button();
            label15 = new Label();
            label16 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 12);
            label1.Name = "label1";
            label1.Size = new Size(225, 46);
            label1.TabIndex = 0;
            label1.Text = "Staff Control";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(unpayedbalanceLabel);
            groupBox1.Controls.Add(extrahoursLabel);
            groupBox1.Controls.Add(unpayedhoursLabel);
            groupBox1.Controls.Add(staffidLabel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 81);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(605, 263);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(382, 73);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(174, 103);
            button1.TabIndex = 8;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // unpayedbalanceLabel
            // 
            unpayedbalanceLabel.AutoSize = true;
            unpayedbalanceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            unpayedbalanceLabel.Location = new Point(155, 195);
            unpayedbalanceLabel.Name = "unpayedbalanceLabel";
            unpayedbalanceLabel.Size = new Size(37, 20);
            unpayedbalanceLabel.TabIndex = 7;
            unpayedbalanceLabel.Text = "0.00";
            // 
            // extrahoursLabel
            // 
            extrahoursLabel.AutoSize = true;
            extrahoursLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            extrahoursLabel.Location = new Point(155, 141);
            extrahoursLabel.Name = "extrahoursLabel";
            extrahoursLabel.Size = new Size(37, 20);
            extrahoursLabel.TabIndex = 6;
            extrahoursLabel.Text = "0.00";
            // 
            // unpayedhoursLabel
            // 
            unpayedhoursLabel.AutoSize = true;
            unpayedhoursLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            unpayedhoursLabel.Location = new Point(155, 92);
            unpayedhoursLabel.Name = "unpayedhoursLabel";
            unpayedhoursLabel.Size = new Size(37, 20);
            unpayedhoursLabel.TabIndex = 5;
            unpayedhoursLabel.Text = "0.00";
            // 
            // staffidLabel
            // 
            staffidLabel.AutoSize = true;
            staffidLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            staffidLabel.Location = new Point(155, 37);
            staffidLabel.Name = "staffidLabel";
            staffidLabel.Size = new Size(57, 20);
            staffidLabel.TabIndex = 4;
            staffidLabel.Text = "Staff Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(7, 195);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 3;
            label5.Text = "Unpayed Balance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(7, 141);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 2;
            label4.Text = "Extra Hours:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(7, 92);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 1;
            label3.Text = "Unpayed Hours:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(7, 37);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 0;
            label2.Text = "Staff ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(extrahourTextBox);
            groupBox2.Controls.Add(normalhourTextBox);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(14, 389);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(605, 211);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Hours";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // extrahourTextBox
            // 
            extrahourTextBox.Location = new Point(130, 124);
            extrahourTextBox.Margin = new Padding(3, 4, 3, 4);
            extrahourTextBox.Name = "extrahourTextBox";
            extrahourTextBox.Size = new Size(182, 27);
            extrahourTextBox.TabIndex = 10;
            // 
            // normalhourTextBox
            // 
            normalhourTextBox.Location = new Point(130, 59);
            normalhourTextBox.Margin = new Padding(3, 4, 3, 4);
            normalhourTextBox.Name = "normalhourTextBox";
            normalhourTextBox.Size = new Size(182, 27);
            normalhourTextBox.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(382, 51);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(174, 104);
            button2.TabIndex = 8;
            button2.Text = "Add Hours";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label15.Location = new Point(7, 129);
            label15.Name = "label15";
            label15.Size = new Size(88, 20);
            label15.TabIndex = 2;
            label15.Text = "Extra Hour:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label16.Location = new Point(7, 64);
            label16.Name = "label16";
            label16.Size = new Size(105, 20);
            label16.TabIndex = 1;
            label16.Text = "Normal Hour:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(169, 631);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(258, 63);
            button3.TabIndex = 9;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // StaffControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 724);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "StaffControl";
            Text = "Staff Control";
            Load += StaffControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label unpayedbalanceLabel;
        private Label extrahoursLabel;
        private Label unpayedhoursLabel;
        private Label staffidLabel;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label15;
        private Label label16;
        private Button button3;
        private TextBox extrahourTextBox;
        private TextBox normalhourTextBox;
    }
}