using System;
using System.Windows.Forms;

namespace _66086_Data_Detectives_Project2
{
    public partial class AccountControl : Form
    {
        private Customer currentCustomer;

        // Constructor that accepts a Customer object
        public AccountControl(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;
        }

        private void AccountControl_Load(object sender, EventArgs e)
        {
            // Display account details
            account.Text = currentCustomer.AccountNumber;
            customerid.Text = currentCustomer.UserId;
            balance.Text = currentCustomer.Balance.ToString("F2");
            savings.Text = currentCustomer.Savings.ToString("F2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowCustomer showCustomer = new ShowCustomer();
            showCustomer.Show();
            this.Close();
        }

        // Deposit button
        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(depositTextBox.Text, out decimal amount) && amount > 0)
            {
                currentCustomer.Deposit(amount);
                balance.Text = currentCustomer.Balance.ToString("F2");
                MessageBox.Show("Deposit successful!", "Success");
                depositTextBox.Clear();  // Clear deposit textbox after deposit
            }
            else
            {
                MessageBox.Show("Invalid deposit amount.", "Error");
            }
        }

        // Withdraw button
        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(withdrawTextBox.Text, out decimal amount) && amount > 0)
            {
                if (currentCustomer.Withdraw(amount))
                {
                    balance.Text = currentCustomer.Balance.ToString("F2");
                    MessageBox.Show("Withdrawal successful!", "Success");
                    withdrawTextBox.Clear();  // Clear withdraw textbox after withdrawal
                }
                else
                {
                    MessageBox.Show("Insufficient balance.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid withdrawal amount.", "Error");
            }
        }

        // Transfer to savings button
        private void buttonTransferToSavings_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(transferTextBox.Text, out decimal amount) && amount > 0)
            {
                if (currentCustomer.TransferToSavings(amount))
                {
                    balance.Text = currentCustomer.Balance.ToString("F2");
                    savings.Text = currentCustomer.Savings.ToString("F2");
                    MessageBox.Show("Transfer to savings successful!", "Success");
                    transferTextBox.Clear();  // Clear transfer textbox after transfer
                }
                else
                {
                    MessageBox.Show("Insufficient balance for transfer.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid transfer amount.", "Error");
            }
        }
    }
}
