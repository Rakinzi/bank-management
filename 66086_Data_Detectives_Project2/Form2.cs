using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _66086_Data_Detectives_Project2
{
    public partial class AddCustomer : Form
    {
        private Customer newCustomer;
        private string profilePicturePath;
        private readonly string imagesFolderPath = Path.Combine(Application.StartupPath, "Images");
        private readonly string placeholderImagePath = Path.Combine(Application.StartupPath, "Images", "placeholder.jpg");

        public AddCustomer()
        {
            InitializeComponent();
            EnsureImagesFolderExists();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            newCustomer = new Customer();
            customerid.Text = newCustomer.UserId;
            accountnumber.Text = newCustomer.AccountNumber;
            plan.Items.Clear();
            foreach (string planOption in newCustomer.PlanList)
            {
                plan.Items.Add(planOption);
            }
            SetPlaceholderImage();
        }

        private void EnsureImagesFolderExists()
        {
            if (!Directory.Exists(imagesFolderPath))
            {
                Directory.CreateDirectory(imagesFolderPath);
            }
        }

        private void SetPlaceholderImage()
        {
            if (File.Exists(placeholderImagePath))
            {
                pictureBox1.Image = Image.FromFile(placeholderImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Placeholder image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Profile Picture";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(selectedFilePath);
                    string destinationPath = Path.Combine(imagesFolderPath, fileName);

                    try
                    {
                        File.Copy(selectedFilePath, destinationPath, true);
                        profilePicturePath = destinationPath;
                        pictureBox1.Image = Image.FromFile(profilePicturePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error copying image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void ReloadForm()
        {
            newCustomer = new Customer();
            customerid.Text = newCustomer.UserId;
            accountnumber.Text = newCustomer.AccountNumber;
            name.Clear();
            lastname.Clear();
            contact.Clear();
            email.Clear();
            address.Clear();
            plan.SelectedIndex = -1;
            balance.Clear();
            profilePicturePath = string.Empty;
            SetPlaceholderImage();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            if (InputValidator.IsEmpty(name.Text)) errors.Add("Name cannot be empty.");
            if (InputValidator.IsEmpty(lastname.Text)) errors.Add("Last name cannot be empty.");
            if (InputValidator.IsEmpty(contact.Text) || !InputValidator.IsValidPhoneNumber(contact.Text)) errors.Add("Please enter a valid contact number.");
            if (InputValidator.IsEmpty(email.Text) || !InputValidator.IsValidEmail(email.Text)) errors.Add("Please enter a valid email address.");
            if (InputValidator.IsEmpty(address.Text)) errors.Add("Address cannot be empty.");
            if (!InputValidator.IsComboBoxSelected(plan)) errors.Add("Please select a plan.");
            if (!InputValidator.IsValidNonNegativeDecimal(balance.Text)) errors.Add("Please enter a valid non-negative balance.");
            if (string.IsNullOrEmpty(profilePicturePath)) errors.Add("Please upload a profile picture.");
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer customer = new Customer
            {
                Name = name.Text.Trim(),
                LastName = lastname.Text.Trim(),
                PhoneNumber = contact.Text.Trim(),
                Email = email.Text.Trim(),
                Address = address.Text.Trim(),
                Plan = plan.SelectedItem.ToString(),
                Balance = decimal.Parse(balance.Text.Trim()),
                Photo = Path.Combine("Images", Path.GetFileName(profilePicturePath))
            };

            BankDataManager.SaveCustomer(customer);
            MessageBox.Show("Customer data saved successfully.", "Success");
            ReloadForm();
        }
    }
}
