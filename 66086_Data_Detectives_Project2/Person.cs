using System;
using System.Windows.Forms;

namespace _66086_Data_Detectives_Project2
{
    // Abstract class Person
    public abstract class Person
    {
        // Properties
        protected string name;
        protected string lastName;
        protected string photo;
        protected string address;
        protected string email;
        protected string phoneNumber;

        // Name property with getter and setter
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    name = value;
                }
            }
        }

        // LastName property with getter and setter
        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Last name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lastName = value;
                }
            }
        }

        // Photo property with getter and setter
        public string Photo
        {
            get => photo;
            set => photo = value;
        }

        // Address property with getter and setter
        public string Address
        {
            get => address;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    address = value;
                }
            }
        }

        // Email property with getter and setter
        public string Email
        {
            get => email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    email = value;
                }
            }
        }

        // PhoneNumber property with getter and setter
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Phone number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    phoneNumber = value;
                }
            }
        }
    }
}
