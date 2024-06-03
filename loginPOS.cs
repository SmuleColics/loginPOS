using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPOS
{
    public partial class loginPOS : Form
    {

        public static string usernameLogin = "", passwordLogin = "";

        public loginPOS()
        {
            InitializeComponent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            signinPOS signinPOS = new signinPOS();
            signinPOS.Show();
        }

        private void loginPOS_Load(object sender, EventArgs e)
        {
            tbEnterPassword.UseSystemPasswordChar = true;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == false)
            {
                tbEnterPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbEnterPassword.UseSystemPasswordChar = false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            OrderingSystem orderingSystem = new OrderingSystem();
            admin admin = new admin();

            usernameLogin = tbEnterUsername.Text;
            passwordLogin = tbEnterPassword.Text;

            if (rbCashierLogin.Checked == true)
            {
                if ((usernameLogin == signinPOS.cashierUsernameSignin) && (passwordLogin == signinPOS.cashierPasswordSignin))
                {
                    MessageBox.Show("Cashier Log In Successful.", "Log In Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    orderingSystem.Show();
                }
                else
                {
                    MessageBox.Show("Credentials Does Not Match", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if ((usernameLogin == signinPOS.adminUsernameSignin) && (passwordLogin == signinPOS.adminPasswordSignin))
                {
                    MessageBox.Show("Admin Log In Successful.", "Log In Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Credentials Does Not Match", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
