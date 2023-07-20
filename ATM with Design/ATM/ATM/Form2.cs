using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace ATM
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
           
        }
        //It will open the database
        SQLiteConnection con = new SQLiteConnection(@"data source=C:\database\atm_system.db");
        private void loginbtn_Click(object sender, EventArgs e)
        {
            //It will get the account number and PIN to check whether the user input is correct or not.
            string accountnumber = accountNumber.Text;
            string pin = PIN.Text;

            // Validate the login credentials
            if (ValidateLogin(accountnumber, pin))
            {
                string accountName;
                con.Open();
                SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Name From Accounts WHERE AccountNumber='" + accountNumber.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                accountName = dt.Rows[0][0].ToString();
                User.LoggedInAccountUser = accountName;
                User.LoggedInAccountNumber = accountNumber.Text;
                con.Close();
                mainMenu menu = new mainMenu();
                menu.Show();
                this.Hide();
            }

            //A scenario if the account number and the PIN are empty.
            else if (accountnumber == "" && pin == "")
            {
                MessageBox.Show("Please fill out the account number and PIN code");
            }

            //A scenario if the account number is empty.
            else if (accountnumber == "")
            {
                MessageBox.Show("Please fill out the account number");
            }

            //A scenario if the PIN is empty.
            else if (pin == "")
            {
                MessageBox.Show("Please fill out the PIN code");
            }

            //If the account number or PIN is incorrect.
            else
            {
                MessageBox.Show("Wrong account number or PIN code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Validates the login credentials for a user account.
        private bool ValidateLogin(string accountNumber, string pin)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\database\atm_system.db");

            using (var connection = new SQLiteConnection(con))
            {
                connection.Open();

                // Prepare the SQL query to retrieve the hashed password for the entered account number.
                string query = "SELECT PIN FROM Accounts WHERE AccountNumber = @AccountNumber OR PIN = @PIN";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    command.Parameters.AddWithValue("@PIN", pin);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPin = reader.GetString(0);

                            // Compare the stored hashed password with the entered PIN code.
                            if (VerifyPassword(pin, storedPin))
                            {
                                // PINs match, login successful.
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private bool VerifyPassword(string pin, string storedHash)
        {
            // Compare the entered password with the stored hash.
            // Use the same hashing algorithm and method you used during registration.
            string enteredHash = HashPin(pin);

            // Compare the stored hash and entered hash
            return storedHash.Equals(enteredHash);
        }

        private string HashPin(string pin)
        {
            using (var sha256 = SHA256.Create())
            {
                // Convert the password to bytes.
                byte[] passwordBytes = Encoding.UTF8.GetBytes(pin);

                // Compute the hash value of the password bytes.
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hash bytes to a hexadecimal string.
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); // "x2" formats each byte as a two-digit hexadecimal number
                }

                return builder.ToString();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        //A button with the "1" text
        private void onebtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "1";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "1";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }
            
        }
        //A button with the "2" text
        private void twobtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "2";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "2";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }

        }
        //A button with the "3" text
        private void threebtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "3";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "3";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }

        }
        //A button with the "4" text
        private void fourbtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "4";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "4";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }

        }
        //A button with the "5" text
        private void fivebtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "5";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "5";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }

        }
        //A button with the "6" text
        private void sixbtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "6";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "6";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }

        }
        //A button with the "7" text
        private void sevenbtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "7";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "7";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }

        }
        //A button with the "8" text
        private void eightbtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "8";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "8";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }

        }
        //A button with the "9" text
        private void ninebtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "9";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "9";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }

        }
        //A button with the "0" text
        private void zerobtn_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "0";
            }
            else if (accountNumber.Text.Length == 8)
            {
                if (PIN.Text.Length != 4)
                {
                    PIN.Text = PIN.Text + "0";
                }
                else if (PIN.Text.Length == 4)
                {

                }
            }

        }

        //When clicking the clear button, it will clear the textbox.
        private void clearbtn_Click(object sender, EventArgs e)
        {
            accountNumber.Text = "";
            PIN.Text = "";
           
        }

     

      
        private void PIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountNumber_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
