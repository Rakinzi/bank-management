# Bank Management System

A comprehensive Windows Forms application for managing bank customers and staff operations, developed by the **Data Detectives** team.

## 📋 Project Overview

This Bank Management System is a desktop application built using C# and Windows Forms (.NET 8.0) that provides a complete solution for managing bank operations including customer accounts, staff management, and financial transactions.

## ✨ Features

### Customer Management
- **Add New Customers**: Register customers with personal details, account plans, and profile pictures
- **View Customer Records**: Browse through customer database with pagination
- **Edit Customer Information**: Update customer details and profile pictures
- **Account Operations**:
  - Deposit money
  - Withdraw money
  - Transfer funds to savings account
  - View account balance and savings

### Staff Management
- **Add New Staff**: Register staff members with role-based salary structures
- **View Staff Records**: Browse through staff database with pagination
- **Staff Control Panel**:
  - Add working hours (normal and overtime)
  - Calculate salary automatically based on role and hours
  - Process payments and reset balances
  - Track unpaid hours and balances

### Data Management
- **Persistent Storage**: Data stored in text files (customers.txt, staff.txt)
- **Unique ID Generation**: Automatic generation of unique customer and staff IDs
- **Image Management**: Profile picture storage and display
- **Input Validation**: Comprehensive validation for all user inputs

## 🏗️ Project Structure

```
66086_Data_Detectives_Project2/
├── BankManagement.cs          # Data management and file operations
├── Customer.cs                # Customer class with account operations
├── Staff.cs                   # Staff class with salary calculations
├── Person.cs                  # Abstract base class for Customer and Staff
├── StaffRole.cs              # Enum for staff roles
├── Utility.cs                # Input validation utilities
├── Program.cs                # Application entry point
├── Form1.cs (MainMenu)       # Main navigation form
├── Form2.cs (AddCustomer)    # Add customer form
├── Form3.cs (ShowCustomer)   # View customers form
├── Form4.cs (EditCustomer)   # Edit customer form
├── Form5.cs (AccountControl) # Customer account operations
├── Form6.cs (AddStaff)       # Add staff form
├── Form7.cs (ShowStaff)      # View staff form
└── Form8.cs (StaffControl)   # Staff management operations
```

## 🚀 Getting Started

### Prerequisites
- **Operating System**: Windows 7 or later
- **.NET Runtime**: .NET 8.0 Desktop Runtime
- **Development**: Visual Studio 2022 or later (for development)

### Installation
1. Clone or download the project
2. Open `66086_Data_Detectives_Project2.sln` in Visual Studio
3. Build the solution (Build → Build Solution)
4. Run the application (Debug → Start Debugging or F5)

### First Run Setup
1. The application will create necessary directories automatically
2. Place a placeholder image named `placeholder.jpg` in the `Images` folder for default profile pictures
3. The application will generate `customers.txt` and `staff.txt` files for data storage

## 💼 Usage Guide

### Main Menu
The application starts with a main menu offering two primary sections:
- **Customer Control**: Add and manage customers
- **Staff Control**: Add and manage staff members

### Customer Operations

#### Adding a Customer
1. Navigate to **Customer Control** → **Add Customers**
2. Fill in required information:
   - Name and Last Name
   - Contact number and Email
   - Address
   - Select a plan (Silver, Gold, Platinum, Diamond, Bronze)
   - Initial balance
   - Upload profile picture
3. Click **Save** to register the customer

#### Managing Customer Accounts
1. Go to **Customer Control** → **Show Customers**
2. Browse customers using navigation arrows
3. Use **Edit** to modify customer information
4. Use **Control Balance** for financial operations:
   - **Deposit**: Add money to account
   - **Withdraw**: Remove money from account
   - **Move to Savings**: Transfer money to savings account

### Staff Operations

#### Adding Staff
1. Navigate to **Staff Control** → **Add Staff**
2. Enter staff details:
   - Name and Last Name
   - Contact information and Address
   - Select role (affects salary):
     - General Manager: $100/hour
     - Branch Manager: $80/hour
     - Accountant: $60/hour
     - Teller: $40/hour
   - Upload profile picture
3. Click **Save** to register the staff member

#### Managing Staff
1. Go to **Staff Control** → **Show Staff**
2. Browse staff using navigation arrows
3. Use **Staff Managing** for operations:
   - **Add Hours**: Record normal and overtime hours
   - **Pay**: Process payment and reset balances
   - View unpaid hours and calculated balance

## 💾 Data Storage

### File Format
- **Location**: Application directory
- **Format**: Pipe-delimited text files
- **Files**:
  - `customers.txt`: Customer records
  - `staff.txt`: Staff records

### Customer Data Structure
```
UserID|Name|LastName|Photo|Address|Email|PhoneNumber|Plan|Balance|Savings|AccountNumber
```

### Staff Data Structure
```
StaffID|Name|LastName|Photo|Address|Email|PhoneNumber|Role|StaffBalance|NormalHours|ExtraHours|SalaryPerHour|UnpaidHours
```

## 🔧 Technical Details

### Architecture
- **Pattern**: Object-Oriented Programming with inheritance
- **UI Framework**: Windows Forms
- **Data Layer**: File-based storage with thread-safe operations
- **Validation**: Comprehensive input validation system

### Key Classes
- **`Person`**: Abstract base class for common properties
- **`Customer`**: Handles customer data and account operations
- **`Staff`**: Manages staff information and salary calculations
- **`BankDataManager`**: Static class for all file operations
- **`InputValidator`**: Utility class for input validation

### Unique Features
- **Thread-safe file operations** using locks
- **Automatic ID generation** with collision detection
- **Role-based salary calculation** with overtime support (1.4x multiplier)
- **Image management** with automatic directory creation
- **Real-time balance updates** with persistent storage

## 🛠️ Development

### Building from Source
```bash
# Clone the repository
git clone https://github.com/Rakinzi/bank-management

# Open in Visual Studio
# Build → Build Solution

# Or use command line
dotnet build
```

### Contributing
1. Fork the project
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

## 📝 License

This project is developed by the **Data Detectives** team as an educational project.

## 🐛 Known Issues

- Profile pictures must be manually placed in the Images folder
- Data validation could be enhanced for edge cases
- No database backup functionality currently implemented

## 📞 Support

For issues or questions regarding this Bank Management System, please contact the Data Detectives development team.

---

**Developed by Rakinzi**  
*A comprehensive solution for modern banking operations*
