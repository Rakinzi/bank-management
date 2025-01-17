using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _66086_Data_Detectives_Project2
{
    public partial class AddStaff : Form
    {
        private string profilePicturePath;
        private readonly string imagesFolderPath = Path.Combine(Application.StartupPath, "Images");
        private readonly string placeholderImagePath = Path.Combine(Application.StartupPath, "Images", "placeholder.jpg");

        public AddStaff()
        {
            InitializeComponent();
            EnsureImagesFolderExists();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            role.DataSource = Enum.GetValues(typeof(StaffRole));
            staffid.Text = staff.StaffId;
        }

        private void EnsureImagesFolderExists()
        {
            if (!Directory.Exists(imagesFolderPath))
            {
                Directory.CreateDirectory(imagesFolderPath);
            }
        }

        private void ClearForm()
        {
            name.Clear();
            lastname.Clear();
            address.Clear();
            email.Clear();
            contact.Clear();
            role.SelectedIndex = -1;
            SetPlaceholderImage();
            profilePicturePath = string.Empty;
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
                pictureBox1.Image = null;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (InputValidator.IsEmpty(name.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (InputValidator.IsEmpty(lastname.Text))
            {
                MessageBox.Show("Last name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (InputValidator.IsEmpty(address.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!InputValidator.IsValidEmail(email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!InputValidator.IsValidPhoneNumber(contact.Text))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!InputValidator.IsComboBoxSelected(role))
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(profilePicturePath))
            {
                MessageBox.Show("Please upload a profile picture.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Staff newStaff = new Staff
            {
                StaffId = staffid.Text.Trim(),
                Name = name.Text.Trim(),
                LastName = lastname.Text.Trim(),
                Address = address.Text.Trim(),
                Email = email.Text.Trim(),
                PhoneNumber = contact.Text.Trim(),
                Role = (StaffRole)role.SelectedItem,
                Photo = Path.Combine("Images", Path.GetFileName(profilePicturePath))
            };

            BankDataManager.SaveStaff(newStaff);

            MessageBox.Show("Staff member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            Staff staff = new Staff();
            staffid.Text = staff.StaffId;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
