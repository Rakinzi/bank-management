using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _66086_Data_Detectives_Project2
{
    public partial class EditCustomer : Form
    {
        private Customer currentCustomer;
        private string newProfilePicturePath;

        // Constructor that accepts a Customer object
        public EditCustomer(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            // Populate the form fields with the customer's data
            name.Text = currentCustomer.Name;
            lastname.Text = currentCustomer.LastName;
            address.Text = currentCustomer.Address;
            email.Text = currentCustomer.Email;
            contact.Text = currentCustomer.PhoneNumber;
            account.Text = currentCustomer.AccountNumber;
            balance.Text = currentCustomer.Balance.ToString("F2");
            plan.Text = currentCustomer.Plan;
            customerid.Text = currentCustomer.UserId;
            savings.Text = currentCustomer.Savings.ToString("F2");

            // Load existing profile picture
            LoadCustomerImage(currentCustomer.Photo);
        }

        private void LoadCustomerImage(string photoPath)
        {
            if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
            {
                pictureBox1.Image = Image.FromFile(photoPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                string placeholderPath = Path.Combine(Application.StartupPath, "Images", "placeholder.png");
                if (File.Exists(placeholderPath))
                {
                    pictureBox1.Image = Image.FromFile(placeholderPath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a New Profile Picture";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    newProfilePicturePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(newProfilePicturePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowCustomer showCustomer = new ShowCustomer();
            showCustomer.Show();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Update the customer object with the edited data
            currentCustomer.Name = name.Text.Trim();
            currentCustomer.LastName = lastname.Text.Trim();
            currentCustomer.Address = address.Text.Trim();
            currentCustomer.Email = email.Text.Trim();
            currentCustomer.PhoneNumber = contact.Text.Trim();
            currentCustomer.Plan = plan.Text.Trim();
            currentCustomer.Balance = decimal.Parse(balance.Text.Trim());
            currentCustomer.Savings = decimal.Parse(savings.Text.Trim());

            // Update profile picture if a new one was selected
            if (!string.IsNullOrEmpty(newProfilePicturePath))
            {
                currentCustomer.Photo = newProfilePicturePath;
            }

            // Save updated customer to file
            BankDataManager.UpdateCustomer(currentCustomer);

            MessageBox.Show("Customer details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowCustomer showCustomer = new ShowCustomer();
            showCustomer.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
