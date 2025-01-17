using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _66086_Data_Detectives_Project2
{
    public partial class ShowCustomer : Form
    {
        private List<Customer> customers;
        private int currentIndex = 0;
        private readonly string placeholderImagePath = Path.Combine(Application.StartupPath, "Images", "placeholder.png");

        public ShowCustomer()
        {
            InitializeComponent();
        }

        private void ShowCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            DisplayCustomerDetails(currentIndex);
        }

        private void LoadCustomers()
        {
            customers = BankDataManager.LoadCustomers();
            if (customers.Count == 0)
            {
                MessageBox.Show("No customers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }
        }

        private void DisplayCustomerDetails(int index)
        {
            if (customers.Count == 0 || index < 0 || index >= customers.Count)
                return;

            Customer customer = customers[index];
            name.Text = customer.Name;
            lastname.Text = customer.LastName;
            address.Text = customer.Address;
            email.Text = customer.Email;
            phone.Text = customer.PhoneNumber;
            accountnumber.Text = customer.AccountNumber;
            balance.Text = customer.Balance.ToString("F2");
            plan.Text = customer.Plan;
            customerid.Text = customer.UserId;
            savings.Text = customer.Savings.ToString("F2");
            pagination.Text = $"{index + 1} of {customers.Count}";

            // Load and display the customer's profile picture
            LoadCustomerImage(customer.Photo);
        }

        private void LoadCustomerImage(string photoPath)
        {
            if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
            {
                picture.Image = Image.FromFile(photoPath);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (File.Exists(placeholderImagePath))
            {
                picture.Image = Image.FromFile(placeholderImagePath);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayCustomerDetails(currentIndex);
            }
            else
            {
                MessageBox.Show("This is the first customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < customers.Count - 1)
            {
                currentIndex++;
                DisplayCustomerDetails(currentIndex);
            }
            else
            {
                MessageBox.Show("This is the last customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer(customers[currentIndex]);
            editCustomer.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountControl accountControl = new AccountControl(customers[currentIndex]);
            accountControl.Show();
            this.Hide();
        }
    }
}
