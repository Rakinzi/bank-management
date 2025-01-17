namespace _66086_Data_Detectives_Project2
{
    partial class AccountControl
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
            savings = new Label();
            balance = new Label();
            customerid = new Label();
            account = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            buttonWithdraw = new Button();
            withdrawTextBox = new TextBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            buttonTransferToSavings = new Button();
            transferTextBox = new TextBox();
            label11 = new Label();
            groupBox4 = new GroupBox();
            buttonDeposit = new Button();
            depositTextBox = new TextBox();
            label12 = new Label();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 0;
            label1.Text = "Account Control";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(savings);
            groupBox1.Controls.Add(balance);
            groupBox1.Controls.Add(customerid);
            groupBox1.Controls.Add(account);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(16, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 188);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Info";
            // 
            // savings
            // 
            savings.AutoSize = true;
            savings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            savings.Location = new Point(163, 150);
            savings.Name = "savings";
            savings.Size = new Size(55, 15);
            savings.TabIndex = 7;
            savings.Text = "Account:";
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            balance.Location = new Point(163, 112);
            balance.Name = "balance";
            balance.Size = new Size(55, 15);
            balance.TabIndex = 6;
            balance.Text = "Account:";
            // 
            // customerid
            // 
            customerid.AutoSize = true;
            customerid.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            customerid.Location = new Point(163, 72);
            customerid.Name = "customerid";
            customerid.Size = new Size(55, 15);
            customerid.TabIndex = 5;
            customerid.Text = "Account:";
            // 
            // account
            // 
            account.AutoSize = true;
            account.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            account.Location = new Point(163, 35);
            account.Name = "account";
            account.Size = new Size(55, 15);
            account.TabIndex = 4;
            account.Text = "Account:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(7, 150);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 3;
            label5.Text = "Savings:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(7, 112);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 2;
            label4.Text = "Balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(7, 72);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 1;
            label3.Text = "Customer ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(7, 35);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Account:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonWithdraw);
            groupBox2.Controls.Add(withdrawTextBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(16, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(523, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Withdraw";
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.BackColor = Color.FromArgb(192, 0, 192);
            buttonWithdraw.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            buttonWithdraw.Location = new Point(383, 24);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new Size(119, 48);
            buttonWithdraw.TabIndex = 6;
            buttonWithdraw.Text = "Withdraw";
            buttonWithdraw.UseVisualStyleBackColor = false;
            buttonWithdraw.Click += buttonWithdraw_Click;
            // 
            // withdrawTextBox
            // 
            withdrawTextBox.Location = new Point(170, 38);
            withdrawTextBox.Name = "withdrawTextBox";
            withdrawTextBox.Size = new Size(164, 21);
            withdrawTextBox.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(7, 42);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 4;
            label10.Text = "Withdraw Amount:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonTransferToSavings);
            groupBox3.Controls.Add(transferTextBox);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(16, 393);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(523, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Move to Saving";
            // 
            // buttonTransferToSavings
            // 
            buttonTransferToSavings.BackColor = Color.Lime;
            buttonTransferToSavings.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            buttonTransferToSavings.Location = new Point(383, 24);
            buttonTransferToSavings.Name = "buttonTransferToSavings";
            buttonTransferToSavings.Size = new Size(119, 48);
            buttonTransferToSavings.TabIndex = 6;
            buttonTransferToSavings.Text = "Move";
            buttonTransferToSavings.UseVisualStyleBackColor = false;
            buttonTransferToSavings.Click += buttonTransferToSavings_Click;
            // 
            // transferTextBox
            // 
            transferTextBox.Location = new Point(170, 38);
            transferTextBox.Name = "transferTextBox";
            transferTextBox.Size = new Size(164, 21);
            transferTextBox.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.Location = new Point(7, 42);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 4;
            label11.Text = "Moving Amount:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonDeposit);
            groupBox4.Controls.Add(depositTextBox);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(16, 519);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(523, 100);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Deposit";
            // 
            // buttonDeposit
            // 
            buttonDeposit.BackColor = Color.Cyan;
            buttonDeposit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            buttonDeposit.Location = new Point(383, 24);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(119, 48);
            buttonDeposit.TabIndex = 6;
            buttonDeposit.Text = "Deposit";
            buttonDeposit.UseVisualStyleBackColor = false;
            buttonDeposit.Click += buttonDeposit_Click;
            // 
            // depositTextBox
            // 
            depositTextBox.Location = new Point(170, 38);
            depositTextBox.Name = "depositTextBox";
            depositTextBox.Size = new Size(164, 21);
            depositTextBox.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label12.Location = new Point(7, 42);
            label12.Name = "label12";
            label12.Size = new Size(98, 15);
            label12.TabIndex = 4;
            label12.Text = "Deposit Amount:";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button4.Location = new Point(157, 631);
            button4.Name = "button4";
            button4.Size = new Size(255, 48);
            button4.TabIndex = 7;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AccountControl
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 691);
            Controls.Add(button4);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AccountControl";
            Text = "Account Control";
            Load += AccountControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label savings;
        private Label balance;
        private Label customerid;
        private Label account;
        private GroupBox groupBox2;
        private Label label10;
        private TextBox withdrawTextBox;
        private Button buttonWithdraw;
        private GroupBox groupBox3;
        private Button buttonTransferToSavings;
        private TextBox transferTextBox;
        private Label label11;
        private GroupBox groupBox4;
        private Button buttonDeposit;
        private TextBox depositTextBox;
        private Label label12;
        private Button button4;
    }
}