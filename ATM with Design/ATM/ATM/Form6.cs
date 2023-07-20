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
using System.Text.RegularExpressions;

namespace ATM
{
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }

        //It will open the database.
        SQLiteConnection con = new SQLiteConnection(@"data source=C:\database\atm_system.db");

        string account = User.LoggedInAccountNumber;



        //It will get the current balance of the account number.
        private void deposit_Load(object sender, EventArgs e)
        {
             getBalance();
        }

        //A button with the "1" text
        private void onebtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "1";
        }

        //A button with the "2" text
        private void twobtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "2";
        }

        //A button with the "3" text
        private void threebtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "3";
        }

        //A button with the "4" text
        private void fourbtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "4";
        }

        //A button with the "5" text
        private void fivebtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "5";
        }

        //A button with the "6" text
        private void sixbtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "6";
        }

        //A button with the "7" text
        private void sevenbtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "7";
        }

        /*  creates a SQLiteDataAdapter object that will execute the SQL
        *   query to retrieve the balance from the Accounts table, specifically
        *   for the account associated with the AccountNumber name. 
        */
        private void getBalance()
        {
            con.Open();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Balance From Accounts WHERE AccountNumber='" + account + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt); //It will contain the results of the SQL query
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();


        }

        //When clicking the 'Return' button, it prompts you to the Main Home Page.
        private void returnBtn_Click(object sender, EventArgs e)
        {
            mainMenu Menu = new mainMenu();
            Menu.Show();
            this.Hide();
        }

        //When clicking the 'Withdraw Money' button, it prompts you to the Withdraw Page.
        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            withdraw Withdraw = new withdraw();
            Withdraw.Show();
            this.Hide();
        }

        //When clicking the 'View Balance' button, it prompts you to the View Balance Page.
        private void viewBalanceBtn_Click(object sender, EventArgs e)
        {
            ViewBalance viewBalance = new ViewBalance();
            viewBalance.Show();
            this.Hide();
        }

        //When clicking the 'Enter' button, it will display a message box based on the condition.
        private void enterbtn_Click(object sender, EventArgs e)
        {
            string amountCheck = amountTextBox.Text;

            //to check whether the amountCheck string contains only numeric digits.
            bool amountResult = Regex.IsMatch(amountCheck, @"^\d+$");

            //If the amountTextBox is empty.
            if (amountTextBox.Text == "")
            {
                MessageBox.Show("Please enter the amount to deposit");
            }

            //It checks if the textbox contains a letter or special character symbols.

            else if (amountResult == false)
            {
                MessageBox.Show("Invalid input for amount");
            }

            //It checks if the textbox is equal to 0.
            else if (Convert.ToInt32(amountTextBox.Text) <= 0)
            {
                MessageBox.Show("Invalid input for amount");
            }

            //If the input of the textbox is valid.
            else
            {
                newBalance = oldBalance + Convert.ToInt32(amountTextBox.Text);
                try
                {
                    con.Open();
                    string query = "Update Accounts set Balance=" + newBalance + " where AccountNumber='" + account + "'";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposit success!!");
                    con.Close();
                    mainMenu menu = new mainMenu();
                    menu.Show();
                    this.Hide();


                }
                //If an exception occurs, the catch block is executed
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
        }

                //Declaring variables
                decimal oldBalance, newBalance;

        //A button with the "9" text
        private void ninebtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "9";
        }

        //A button with the "0" text
        private void zerobtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "0";
        }

        //A clear button that will clear the textbox.
        private void clearbtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = "";
        }

        //A amount textbox where user can enter.
        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //A button with the "8" text
        private void eightbtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "8";
        }
    }
}
