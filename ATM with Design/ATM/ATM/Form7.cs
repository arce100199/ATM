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

namespace ATM
{
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }

        //It will open the database.
        SQLiteConnection con = new SQLiteConnection(@"data source=C:\database\atm_system.db");

        //It will get the account number.
        string account = User.LoggedInAccountNumber;

        //Declares a variable 'newBalance' and 'bal'
        decimal newBalance;
        decimal bal;

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
            decimal balance = Convert.ToDecimal(dt.Rows[0][0]);
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();


        }

        //It will display the balance of the login user.
        private void withdraw_Load_1(object sender, EventArgs e)
        {
            getBalance();
        }

        //A button with the "8" text
        private void eightbtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = amountTextBox.Text + "8";
        }

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

        //A clear button to clear the textbox.
        private void clearbtn_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = "";
        }

        //When clicking the 'Enter' button, it will display a message box based on the condition.
        private void enterbtn_Click(object sender, EventArgs e)
        {
            //If the amountTextBox is empty.
            if (amountTextBox.Text == "")
            {
                MessageBox.Show("Please enter the amount to withdraw");
            }

            //If the entered amount is equal to 0.
            else if (Convert.ToInt32(amountTextBox.Text) <= 0)
            {
                MessageBox.Show("Enter a valid amount");
            }

            //If the entered amount is greater that the current balance.
            else if (Convert.ToInt32(amountTextBox.Text) > bal)
            {
                MessageBox.Show("Insufficient balance");
            }

            //If the input of the textbox is valid.
            else
            {
                try
                {
                    newBalance = bal - Convert.ToInt32(amountTextBox.Text);
                    try
                    {
                        con.Open();
                        string query = "Update Accounts set Balance=" + newBalance + " where AccountNumber='" + account + "'";
                        SQLiteCommand cmd = new SQLiteCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Withdraw success!!");
                        mainMenu menu = new mainMenu();
                        menu.Show();
                        this.Hide();
                        con.Close();

                    }  //If an exception occurs, the catch block is executed
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }    //If an exception occurs, the catch block is executed
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        //A button with the "8" text
        private void viewBalanceBtn_Click(object sender, EventArgs e)
        {
            ViewBalance viewBalance = new ViewBalance();
            viewBalance.Show();
            this.Hide();

        }

        //When clicking the 'Withdraw Money' button, it prompts you to the Withdraw Page.
        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            deposit Deposit = new deposit();
            Deposit.Show();
            this.Hide();
        }

        //When clicking the 'Return' button, it prompts you to the Main Home Page Page.
        private void returnBtn_Click(object sender, EventArgs e)
        {
            mainMenu Menu = new mainMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
