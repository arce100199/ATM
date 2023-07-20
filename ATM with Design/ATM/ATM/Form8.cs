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
    public partial class pinChange : Form
    {
        public pinChange()
        {
            InitializeComponent();
        }

        //It will open the database.
        SQLiteConnection con = new SQLiteConnection(@"data source=C:\database\atm_system.db");
        string account = User.LoggedInAccountNumber;
        

       
        private string HashPin(string pin)
        {
            using (var sha256 = SHA256.Create())
            {
                // Convert the password to bytes
                byte[] passwordBytes = Encoding.UTF8.GetBytes(pin);

                // Compute the hash value of the password bytes
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hash bytes to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); // "x2" formats each byte as a two-digit hexadecimal number
                }

                return builder.ToString();
            }
        }

        private void pinChange_Load(object sender, EventArgs e)
        {

        }


        //A button with the "1" text.
        private void onebtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "1";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "1";
                }
                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length !=4)
                    {
                        newPIN.Text = newPIN.Text + "1";
                    }
                    else
                    {

                    }
                }
            }
        }


        //A button with the "2" text.
        private void twobtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "2";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "2";
                }
                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length != 4)
                    {
                        newPIN.Text = newPIN.Text + "2";
                    }
                    else
                    {

                    }
                }
            }
        }


        //A button with the "3" text.
        private void threebtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "3";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "3";
                }
                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length != 4)
                    {
                        newPIN.Text = newPIN.Text + "3";
                    }
                    else
                    {

                    }
                }
            }
        }


        //A button with the "4" text.
        private void fourbtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "4";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "4";
                }
                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length != 4)
                    {
                        newPIN.Text = newPIN.Text + "4";
                    }
                    else
                    {

                    }
                }
            }
        }


        //A button with the "5" text.
        private void fivebtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "5";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "5";
                }
                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length != 4)
                    {
                        newPIN.Text = newPIN.Text + "5";
                    }
                    else
                    {

                    }
                }
            }
        }


        //A button with the "6" text.
        private void sixbtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "6";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "6";
                }
                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length != 4)
                    {
                        newPIN.Text = newPIN.Text + "6";
                    }
                    else
                    {

                    }
                }
            }
        }


        //A button with the "7" text.
        private void sevenbtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "7";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "7";
                }
                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length != 4)
                    {
                        newPIN.Text = newPIN.Text + "7";
                    }
                    else
                    {

                    }
                }
            }
        }


        //A button with the "8" text.
        private void eightbtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "8";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "8";
                }
                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length != 4)
                    {
                        newPIN.Text = newPIN.Text + "8";
                    }
                    else
                    {

                    }
                }
            }
        }

        //A button with the "9" text.
        private void ninebtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "9";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "9";
                }
                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length != 4)
                    {
                        newPIN.Text = newPIN.Text + "9";
                    }
                    else
                    {

                    }
                }
            }
        }

        //A button with the "0" text.
        private void zerobtn_Click(object sender, EventArgs e)
        {
            //If the length of the account number is not equal to 8.
            if (accountNumber.Text.Length != 8)
            {
                accountNumber.Text = accountNumber.Text + "0";
            }
            //If the length of the account number is equal to 8.
            else if (accountNumber.Text.Length == 8)
            {
                //If the length of the PIN is not equal to 4.
                if (pin.Text.Length != 4)
                {
                    pin.Text = pin.Text + "0";
                }

                //If the length of the PIN is equal to 4.
                else if (pin.Text.Length == 4)
                {
                    //If the length of the new PIN is not equal to 4.
                    if (newPIN.Text.Length != 4)
                    {
                        newPIN.Text = newPIN.Text + "0";
                    }
                    else
                    {

                    }
                }
            }
        }
       

        private void enterbtn_Click(object sender, EventArgs e)
        {
           //If the account number entered is incorrect.
           if(accountNumber.Text != account)
            {
                MessageBox.Show("Wrong account number");
            }

           //If the entered confirm PIN did not match the new PIN entered.
            else if (newPIN.Text != pin.Text)
            {
                MessageBox.Show("PINs do not match!!");
            }
            //If the PIN and Confirm PIN are match.
            else
            {
                string pin = newPIN.Text;
                try
                {

                    string hashPin = HashPin(pin);
                    con.Open();
                    string query = "Update Accounts set PIN='" + hashPin + "' where AccountNumber='" + account + "'"; //It will update the new PIN to the database.
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN successfully changed!!"); //It will show the message that the PIN is successfully changed.
                    login Login = new login();
                    Login.Show();
                    this.Hide();
                    con.Close();

                }
                //If an exception occurs, the catch block is executed
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //When clicking the clear button, it will clear all the textboxes.
        private void clearbtn_Click(object sender, EventArgs e)
        {
            accountNumber.Text = "";
            pin.Text = "";
            newPIN.Text = "";
        }
    }
}
