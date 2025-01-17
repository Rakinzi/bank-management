using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _66086_Data_Detectives_Project2
{
    public partial class ShowStaff : Form
    {
        private List<Staff> staffList;
        private int currentIndex = 0;

        public ShowStaff()
        {
            InitializeComponent();
        }

        private void ShowStaff_Load(object sender, EventArgs e)
        {
            LoadStaffData();
            if (staffList.Count > 0)
            {
                DisplayStaffDetails(currentIndex);
            }
            else
            {
                MessageBox.Show("No staff data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
        }

        private void LoadStaffData()
        {
            staffList = BankDataManager.LoadStaff();
        }

        private void DisplayStaffDetails(int index)
        {
            if (index >= 0 && index < staffList.Count)
            {
                Staff staff = staffList[index];
                name.Text = staff.Name;
                lastname.Text = staff.LastName;
                address.Text = staff.Address;
                email.Text = staff.Email;
                contact.Text = staff.PhoneNumber;
                role.Text = staff.Role.ToString();
                balance.Text = staff.StaffBalance.ToString("F2");
                staffid.Text = staff.StaffId;
                hours.Text = staff.NormalWorkingHours.ToString("F2");
                extrahours.Text = staff.ExtraWorkingHours.ToString("F2");
                salaryphr.Text = staff.SalaryPerHour.ToString("F2");
                pagination.Text = $"{index + 1} of {staffList.Count}";

                if (!string.IsNullOrEmpty(staff.Photo) && File.Exists(staff.Photo))
                {
                    pictureBox1.Image = Image.FromFile(staff.Photo);
                }
                else
                {
                    pictureBox1.Image = null;  // Or set a default image
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < staffList.Count - 1)
            {
                currentIndex++;
                DisplayStaffDetails(currentIndex);
            }
            else
            {
                MessageBox.Show("This is the last staff member.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayStaffDetails(currentIndex);
            }
            else
            {
                MessageBox.Show("This is the first staff member.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label8_Click(object sender, EventArgs e) { }

        private void label16_Click(object sender, EventArgs e) { }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (staffList.Count == 0)
            {
                MessageBox.Show("No staff data available to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pass the current staff to the StaffControl form
            this.Close();
            StaffControl staffControl = new StaffControl(staffList[currentIndex]);
            staffControl.ShowDialog(); // Open as modal dialog to wait for updates


            // Refresh the displayed staff details after editing
            DisplayStaffDetails(currentIndex);
        }

    }
}
