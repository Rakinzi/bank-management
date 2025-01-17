using System;
using System.Windows.Forms;

namespace _66086_Data_Detectives_Project2
{
    public partial class StaffControl : Form
    {
        private Staff currentStaff;

        // Constructor that accepts a Staff object
        public StaffControl(Staff staff)
        {
            InitializeComponent();
            currentStaff = staff;
        }

        private void StaffControl_Load(object sender, EventArgs e)
        {
            // Populate fields with staff details
            staffidLabel.Text = currentStaff.StaffId;
            unpayedhoursLabel.Text = currentStaff.UnpaidHours.ToString("F2");
            extrahoursLabel.Text = currentStaff.ExtraWorkingHours.ToString("F2");
            unpayedbalanceLabel.Text = currentStaff.StaffBalance.ToString("F2");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double normalhours = 0;
            double extrahours = 0;

            // Validate normalhours input
            if (string.IsNullOrWhiteSpace(normalhourTextBox.Text))
            {
                normalhours = 0;
            }
            else if (!double.TryParse(normalhourTextBox.Text, out normalhours))
            {
                MessageBox.Show("Invalid input for normal hours. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate extrahours input
            if (string.IsNullOrWhiteSpace(extrahourTextBox.Text))
            {
                extrahours = 0;
            }
            else if (!double.TryParse(extrahourTextBox.Text, out extrahours))
            {
                MessageBox.Show("Invalid input for extra hours. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the staff object
            currentStaff.NormalWorkingHours += normalhours;
            currentStaff.ExtraWorkingHours += extrahours;

            // Calculate unpaid balance based on both normal and extra working hours
            currentStaff.UnpaidHours = currentStaff.NormalWorkingHours;
            decimal normalPay = (decimal)currentStaff.NormalWorkingHours * currentStaff.SalaryPerHour;
            decimal extraPay = (decimal)currentStaff.ExtraWorkingHours * (currentStaff.SalaryPerHour * 1.4m);
            currentStaff.StaffBalance = normalPay + extraPay; // Reset balance instead of accumulating

            // Save the updated staff details
            BankDataManager.UpdateStaff(currentStaff);

            // Update displayed values
            unpayedhoursLabel.Text = currentStaff.NormalWorkingHours.ToString("F2");
            extrahoursLabel.Text = currentStaff.ExtraWorkingHours.ToString("F2");
            unpayedbalanceLabel.Text = currentStaff.StaffBalance.ToString("F2");

            // Clear input fields
            normalhourTextBox.Clear();
            extrahourTextBox.Clear();

            // Confirmation message
            MessageBox.Show("Hours and unpaid balance updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reset staff balance and hours after payment
            currentStaff.StaffBalance = 0;
            currentStaff.NormalWorkingHours = 0;
            currentStaff.ExtraWorkingHours = 0;
            currentStaff.UnpaidHours = 0;

            BankDataManager.UpdateStaff(currentStaff);

            unpayedhoursLabel.Text = currentStaff.NormalWorkingHours.ToString("F2");
            extrahoursLabel.Text = currentStaff.ExtraWorkingHours.ToString("F2");
            unpayedbalanceLabel.Text = currentStaff.StaffBalance.ToString("F2");

            MessageBox.Show("Payment processed and all balances reset successfully!", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowStaff showStaff = new ShowStaff();
            showStaff.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
