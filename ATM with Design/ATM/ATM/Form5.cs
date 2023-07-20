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
    public partial class ViewBalance : Form
    {
        public ViewBalance()
        {
            InitializeComponent();
        }

        //It will open the database.
        SQLiteConnection con = new SQLiteConnection(@"data source=C:\database\atm_system.db");

        //It will display the current balance of the account number.
        private void ViewBalance_Load(object sender, EventArgs e)
        {         
            getBalance();
        }

        //It will get the username of the account number.
        string accountUser = User.LoggedInAccountUser;

        /*  creates a SQLiteDataAdapter object that will execute the SQL
        *   query to retrieve the balance from the Accounts table, specifically
        *   for the account associated with the accountUser name. 
        */
        private void getBalance()
        {
            con.Open();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Balance From Accounts WHERE Name='" + accountUser + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt); //it will contain the results of the SQL query
            decimal balance = Convert.ToDecimal(dt.Rows[0][0]); 
            balanceLabel.Text = balance.ToString("0.00");
            con.Close();


        }

        //When clicking the 'Return' button, it prompts you to the Main Home Page.
        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu mm = new mainMenu();
            mm.Show();
            this.Hide();
        }

        //When clicking the 'Deposit' button, it prompts you to the Deposit Page.
        private void depositBtn_Click(object sender, EventArgs e)
        {
            deposit Deposit = new deposit();
            Deposit.Show();
            this.Hide();

        }

        //When clicking the 'Withdraw' button, it prompts you to the Withdraw Page.
        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            withdraw Withdraw = new withdraw();
            Withdraw.Show();
            this.Hide();
        }
    }
}
