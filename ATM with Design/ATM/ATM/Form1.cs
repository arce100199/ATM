using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
           
        }

        private void login_Click(object sender, EventArgs e)
            //Redirect to login page
        {
            login newLogin = new login();
            newLogin.Show();
            this.Hide();
        }

     
        //It will exit the application
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
