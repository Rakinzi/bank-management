namespace _66086_Data_Detectives_Project2
{
    partial class MainMenu
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 0;
            label1.Text = "Bank Management";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Cyan;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 9.75F);
            groupBox1.Location = new Point(18, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 150);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Control";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F);
            button3.Location = new Point(84, 89);
            button3.Name = "button3";
            button3.Size = new Size(194, 32);
            button3.TabIndex = 1;
            button3.Text = "Show Customers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F);
            button2.Location = new Point(84, 34);
            button2.Name = "button2";
            button2.Size = new Size(194, 32);
            button2.TabIndex = 0;
            button2.Text = "Add Customers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Yellow;
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Font = new Font("Segoe UI", 9.75F);
            groupBox2.Location = new Point(18, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 150);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Staff Control";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9.75F);
            button5.Location = new Point(84, 92);
            button5.Name = "button5";
            button5.Size = new Size(194, 32);
            button5.TabIndex = 3;
            button5.Text = "Show Staff";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F);
            button4.Location = new Point(84, 35);
            button4.Name = "button4";
            button4.Size = new Size(194, 32);
            button4.TabIndex = 2;
            button4.Text = "Add Staff";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(45, 427);
            label2.Name = "label2";
            label2.Size = new Size(298, 25);
            label2.TabIndex = 3;
            label2.Text = "Programmed By Data Detectives";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(-6, 494);
            button1.Name = "button1";
            button1.Size = new Size(393, 47);
            button1.TabIndex = 4;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 542);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "Main Menu";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
    }
}
