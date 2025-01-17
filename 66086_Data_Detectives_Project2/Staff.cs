using System;

namespace _66086_Data_Detectives_Project2
{
    // Staff class inherits from  Person Abstract class
    public class Staff : Person
    {
        // Properties
        private string staffId;
        private StaffRole role;
        private decimal staffBalance;
        private double normalWorkingHours;
        private double extraWorkingHours;
        private double unpaidHours; // New property
        private decimal salaryPerHour;

        // StaffId property with getter and setter
        public string StaffId
        {
            get => staffId;
            internal set => staffId = value;
        }

        // Role property with getter and setter
        public StaffRole Role
        {
            get => role;
            set
            {
                role = value;
                InitializeSalaryPerHour();
            }
        }

        // StaffBalance property with getter and setter
        public decimal StaffBalance
        {
            get => staffBalance;
            set => staffBalance = value >= 0 ? value : throw new ArgumentException("Balance cannot be negative");
        }

        // NormalWorkingHours property with getter and setter
        public double NormalWorkingHours
        {
            get => normalWorkingHours;
            set => normalWorkingHours = value >= 0 ? value : throw new ArgumentException("Working hours cannot be negative");
        }

        // ExtraWorkingHours property with getter and setter
        public double ExtraWorkingHours
        {
            get => extraWorkingHours;
            set => extraWorkingHours = value >= 0 ? value : throw new ArgumentException("Extra hours cannot be negative");
        }

        // UnpaidHours property with getter and setter
        public double UnpaidHours // New property
        {
            get => unpaidHours;
            set => unpaidHours = value >= 0 ? value : throw new ArgumentException("Unpaid hours cannot be negative");
        }

        // SalaryPerHour property with getter and setter
        public decimal SalaryPerHour
        {
            get => salaryPerHour;
            internal set => salaryPerHour = value >= 0 ? value : throw new ArgumentException("Salary per hour cannot be negative");
        }

        // Staff constructor
        public Staff()
        {
            // Generate unique Staff ID
            StaffId = GenerateUniqueStaffId();
            // Initialize SalaryPerHour based on Role
            InitializeSalaryPerHour();
        }

        // Method to initialize SalaryPerHour based on Role
        private void InitializeSalaryPerHour()
        {
            SalaryPerHour = Role switch
            {
                // Set SalaryPerHour based on Role
                StaffRole.GeneralManager => 100m,
                StaffRole.BranchManager => 80m,
                StaffRole.Accountant => 60m,
                StaffRole.Teller => 40m,
                _ => throw new ArgumentException("Invalid role")
            };
        }

        // Method to calculate the staff salary
        public decimal CalculateSalary()
        {
            decimal normalPay = (decimal)NormalWorkingHours * SalaryPerHour;
            decimal extraPay = (decimal)ExtraWorkingHours * (SalaryPerHour * 1.4m);
            return normalPay + extraPay;
        }

        // Method to generate a unique Staff ID
        private string GenerateUniqueStaffId()
        {
            Random random = new Random();
            char[] prefixLetters = { 'T', 'L', 'X', 'Y', 'Z' };
            char randomLetter = prefixLetters[random.Next(prefixLetters.Length)];
            int randomNumber = random.Next(1000, 9999);
            return $"{randomLetter}-{randomNumber}";
        }
    }
}
