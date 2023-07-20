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
    public partial class mainMenu : Form
    {
     
        public mainMenu()
        {
            InitializeComponent();
            
        }

        //When clicking the 'View Balance' button, it prompts you to the view balance page.
   

        //It will retrieve the account user name based on the signed-in account number.
        SQLiteConnection con = new SQLiteConnection(@"data source=C:\database\atm.db");
        private void mainMenu_Load(object sender, EventArgs e)
        {
            label1.Text = User.LoggedInAccountUser;
        }

        //When clicking the 'View Balance' button, it prompts you to the View Balance Page.
        private void viewBalanceBtn_Click(object sender, EventArgs e)
        {
            ViewBalance viewBalance = new ViewBalance();
            viewBalance.Show();
            this.Hide();
        }

        //When clicking the 'Deposit Money' button, it prompts you to the Deposit Money Page.
        private void depositMoneyBtn_Click(object sender, EventArgs e)
        {
            deposit Deposit = new deposit();
            Deposit.Show();
        }

        //When clicking the 'Change PIN' button, it prompts you to the Change PIN Page.
        private void changePinBtn_Click(object sender, EventArgs e)
        {
            pinChange pCHange = new pinChange();
            pCHange.Show();
            this.Hide();
        }

        //When clicking the 'Withdraw Money' button, it prompts you to the Withdraw Page.
        private void withdrawMoneyBtn_Click(object sender, EventArgs e)
        {
            withdraw Withdraw = new withdraw();
            Withdraw.Show();
            this.Hide();
        }

        //When clicking the 'Log Out' button, it prompts you to the Log Out Page.
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }

        //When clicking the 'Exit' button, it prompts you to the Exit Page.
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
