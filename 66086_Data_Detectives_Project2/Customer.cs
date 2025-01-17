using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _66086_Data_Detectives_Project2
{
    // Customer class inherits from  Person Abstract class
    public class Customer : Person
    {
        // Constants
        private const string CUSTOMERS_FILE = "customers.txt";
        private string userId;
        private string accountNumber;
        private string plan;
        private decimal balance;
        private decimal savings;
        private List<string> planList;

        // User ID property
        public string UserId
        {
            get => userId;
            internal set => userId = value;
        }

        // Account Number property with getter and setter
        public string AccountNumber
        {
            get => accountNumber;
            internal set => accountNumber = value;
        }

        // Plan property with getter and setter
        public string Plan
        {
            get => plan;
            set => plan = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Plan cannot be empty");
        }

        // Balance property with getter and setter
        public decimal Balance
        {
            get => balance;
            set => balance = value >= 0 ? value : throw new ArgumentException("Balance cannot be negative");
        }

        // Savings property with getter and setter
        public decimal Savings
        {
            get => savings;
            set => savings = value >= 0 ? value : throw new ArgumentException("Savings cannot be negative");
        }

        // PlanList property with getter and private setter
        public List<string> PlanList
        {
            get => planList;
            private set => planList = value;
        }

        // Customer constructor
        public Customer()
        {
            // Generate unique User ID and Account Number
            UserId = GenerateUniqueUserId();
            AccountNumber = GenerateUniqueAccountNumber();
            PlanList = GeneratePlans();
        }

        // Method to generate a unique User ID
        private static string GenerateUniqueUserId()
        {
            HashSet<string> existingUserIds = LoadExistingData(0); // UserId is at index 0
            Random random = new Random();
            string newUserId;

            do
            {
                char[] possibleLetters = { 'A', 'B', 'C', 'D', 'E' };
                char letter = possibleLetters[random.Next(possibleLetters.Length)];
                int number = random.Next(1000, 10000);
                newUserId = $"{letter}-{number}";
            } while (existingUserIds.Contains(newUserId));

            return newUserId;
        }

        // Method to generate a unique Account Number
        private static string GenerateUniqueAccountNumber()
        {
            HashSet<string> existingAccountNumbers = LoadExistingData(10); // AccountNumber is at index 10
            Random random = new Random();
            string newAccountNumber;

            do
            {
                string prefix = "5585";
                string part1 = random.Next(1000, 10000).ToString();
                string part2 = random.Next(1000, 10000).ToString();
                string part3 = random.Next(1000, 10000).ToString();
                newAccountNumber = $"{prefix} {part1} {part2} {part3}";
            } while (existingAccountNumbers.Contains(newAccountNumber));

            return newAccountNumber;
        }

        // Helper method to load existing User IDs or Account Numbers from the file
        private static HashSet<string> LoadExistingData(int index)
        {
            HashSet<string> existingData = new HashSet<string>();

            // Load existing data from the file
            if (File.Exists(CUSTOMERS_FILE))
            {
                foreach (var line in File.ReadAllLines(CUSTOMERS_FILE))
                {
                    var parts = line.Split('|');
                    if (parts.Length > index)
                    {
                        existingData.Add(parts[index]);
                    }
                }
            }
            // Return the set of existing data
            return existingData;
        }

        // Generates the list of plans
        private List<string> GeneratePlans()
        {
            return new List<string>
                {
                    "Silver Savings Plan",
                    "Gold Savings Plan",
                    "Platinum Savings Plan",
                    "Diamond Investment Plan",
                    "Bronze Starter Plan",
                };
        }

        // Method to create a new customer
        public bool TransferToSavings(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
                return false;

            Balance -= amount;
            Savings += amount;

            SaveCustomerUpdate();  // Save changes
            return true;
        }

        // Method to deposit money into the account
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false;

            Balance += amount;

            SaveCustomerUpdate();  // Save changes
            return true;
        }

        // Method to withdraw money from the account
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
                return false;

            Balance -= amount;

            SaveCustomerUpdate();  // Save changes
            return true;
        }

        // Method to update the customer in the file
        private void SaveCustomerUpdate()
        {
            var customers = BankDataManager.LoadCustomers();  // Load all customers
            var index = customers.FindIndex(c => c.UserId == this.UserId);  // Find this customer

            if (index != -1)
            {
                customers[index] = this;  // Update this customer's data
                BankDataManager.SaveAllCustomers(customers);  // Save all customers back to file
            }
        }
    }
}
