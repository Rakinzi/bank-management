using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66086_Data_Detectives_Project2
{
    public static class InputValidator
    {
        // Check if input is null, empty, or whitespace
        public static bool IsEmpty(string input) => string.IsNullOrWhiteSpace(input);

        // Validate email format
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Validate phone number (digits only, 7-15 characters)
        public static bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 7 && phone.Length <= 15;
        }

        // Validate decimal input for balance (non-negative)
        public static bool IsValidNonNegativeDecimal(string input)
        {
            return decimal.TryParse(input, out decimal value) && value >= 0;
        }

        // Validate ComboBox selection
        public static bool IsComboBoxSelected(ComboBox comboBox)
        {
            return comboBox.SelectedIndex != -1;
        }
    }
}
