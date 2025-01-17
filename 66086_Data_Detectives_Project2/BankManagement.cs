using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66086_Data_Detectives_Project2
{
    // Class BankDataManager with static methods to save and load customer and staff data
    public static class BankDataManager
    {
        // Constants
        private const string CUSTOMERS_FILE = "customers.txt";
        private const string STAFF_FILE = "staff.txt";
        private static readonly object fileLock = new object();

        // SaveCustomer method to save customer data to file
        public static void SaveCustomer(Customer customer)
        {
            lock (fileLock)
            {
                // Ensure the file exists; if not, create it
                if (!File.Exists(CUSTOMERS_FILE))
                {
                    File.Create(CUSTOMERS_FILE).Close();  // Create and close the file
                }

                string customerData = $"{customer.UserId}|{customer.Name}|{customer.LastName}|{customer.Photo}|" +
                                      $"{customer.Address}|{customer.Email}|{customer.PhoneNumber}|{customer.Plan}|" +
                                      $"{customer.Balance}|{customer.Savings}|{customer.AccountNumber}";

                // Append the customer data to the file
                File.AppendAllLines(CUSTOMERS_FILE, new[] { customerData });
            }
        }

        // SaveStaff method to save staff data to file
        public static void SaveStaff(Staff staff)
        {
            lock (fileLock)
            {
                // Ensure the file exists; if not, create it
                string staffData = $"{staff.StaffId}|{staff.Name}|{staff.LastName}|{staff.Photo}|" +
                                  $"{staff.Address}|{staff.Email}|{staff.PhoneNumber}|{staff.Role}|" +
                                  $"{staff.StaffBalance}|{staff.NormalWorkingHours}|{staff.ExtraWorkingHours}|" +
                                  $"{staff.SalaryPerHour}|{staff.UnpaidHours}";  // Include UnpaidHours

                // Append the staff data to the file
                File.AppendAllLines(STAFF_FILE, new[] { staffData });
            }
        }

        // LoadCustomers method to load customer data from file
        public static List<Customer> LoadCustomers()
        {
            // Create a list to store the loaded customers
            List<Customer> customers = new List<Customer>();
            if (!File.Exists(CUSTOMERS_FILE))
                return customers;

            lock (fileLock)
            {
                // Read each line from the file and create a Customer object
                foreach (string line in File.ReadAllLines(CUSTOMERS_FILE))
                {
                    string[] parts = line.Split('|');
                    if (parts.Length != 11) continue;  // Matches the 11 fields in the file

                    // Create a Customer object from the data
                    try
                    {
                        Customer customer = new Customer
                        {
                            UserId = parts[0],              
                            Name = parts[1],                
                            LastName = parts[2],           
                            Photo = parts[3],              
                            Address = parts[4],
                            Email = parts[5],              
                            PhoneNumber = parts[6],        
                            Plan = parts[7],               
                            Balance = decimal.Parse(parts[8]), 
                            Savings = decimal.Parse(parts[9]), 
                            AccountNumber = parts[10]      
                        };
                        customers.Add(customer);
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that occur during loading
                        MessageBox.Show($"Error loading customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // Return the list of loaded customers
            return customers;
        }

        // LoadStaff method to load staff data from file
        public static List<Staff> LoadStaff()
        {
            // Create a list to store the loaded staff
            List<Staff> staffList = new List<Staff>();
            // Check if the file exists
            if (!File.Exists(STAFF_FILE))
                return staffList;

            lock (fileLock)
            {
                // Read each line from the file and create a Staff object
                foreach (string line in File.ReadAllLines(STAFF_FILE))
                {
                    string[] parts = line.Split('|');
                    if (parts.Length != 13) continue;  // Updated to 13 fields

                    // Create a Staff object from the data
                    try
                    {
                        Staff staff = new Staff
                        {
                            StaffId = parts[0],
                            Name = parts[1],
                            LastName = parts[2],
                            Photo = parts[3],
                            Address = parts[4],
                            Email = parts[5],
                            PhoneNumber = parts[6],
                            Role = Enum.Parse<StaffRole>(parts[7]),
                            StaffBalance = decimal.Parse(parts[8]),
                            NormalWorkingHours = double.Parse(parts[9]),
                            ExtraWorkingHours = double.Parse(parts[10]),
                            SalaryPerHour = decimal.Parse(parts[11]),
                            UnpaidHours = double.Parse(parts[12])  // Load UnpaidHours
                        };
                        staffList.Add(staff);
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that occur during loading
                        MessageBox.Show($"Error loading staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // Return the list of loaded staff
            return staffList;
        }

        // UpdateCustomer method to update customer data
        public static void UpdateCustomer(Customer customer)
        {
            // Load the list of customers
            var customers = LoadCustomers();
            // Find the index of the customer in the list
            var index = customers.FindIndex(c => c.UserId == customer.UserId);

            // If the customer is found, update the customer data and save the changes
            if (index != -1)
            {
                customers[index] = customer;
                SaveAllCustomers(customers);
            }
        }

        // UpdateStaff method to update staff data
        public static void UpdateStaff(Staff staff)
        {
            // Load the list of staff
            var staffList = LoadStaff();

            // Find the index of the staff in the list
            var index = staffList.FindIndex(s => s.StaffId == staff.StaffId);

            // If the staff is found, update the staff data and save the changes
            if (index != -1)
            {
                staffList[index] = staff;
                SaveAllStaff(staffList);
            }
        }

        // SaveAllCustomers method to save all customers to file
        public static void SaveAllCustomers(List<Customer> customers)
        {
            lock (fileLock)
            {
                // Write all customer data to the file
                File.WriteAllLines(CUSTOMERS_FILE, customers.Select(c =>
                    $"{c.UserId}|{c.Name}|{c.LastName}|{c.Photo}|{c.Address}|{c.Email}|" +
                    $"{c.PhoneNumber}|{c.Plan}|{c.Balance}|{c.Savings}|{c.AccountNumber}"));
            }
        }

        // SaveAllStaff method to save all staff to file
        public static void SaveAllStaff(List<Staff> staffList)
        {
            lock (fileLock)
            {
                // Write all staff data to the file
                File.WriteAllLines(STAFF_FILE, staffList.Select(s =>
                    $"{s.StaffId}|{s.Name}|{s.LastName}|{s.Photo}|{s.Address}|{s.Email}|" +
                    $"{s.PhoneNumber}|{s.Role}|{s.StaffBalance}|{s.NormalWorkingHours}|" +
                    $"{s.ExtraWorkingHours}|{s.SalaryPerHour}|{s.UnpaidHours}"));
            }
        }

    }
}
