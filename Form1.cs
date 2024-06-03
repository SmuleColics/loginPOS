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
    public partial class signinPOS : Form
    {

        public static string cashierUsernameSignin = "", cashierPasswordSignin = "";
        public static string adminUsernameSignin = "", adminPasswordSignin = "";
        loginPOS loginPOS = new loginPOS();

        public signinPOS()
        {
            InitializeComponent();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == false)
            {
                tbCreatePassword.UseSystemPasswordChar = true;
                tbConfirmPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbCreatePassword.UseSystemPasswordChar = false;
                tbConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void signinPOS_Load(object sender, EventArgs e)
        {
            tbCreatePassword.UseSystemPasswordChar = true;
            tbConfirmPassword.UseSystemPasswordChar = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPOS.Show();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            bool isValidAccount = true;

            if (tbCreateUsername.Text.Length < 6)
            {
                MessageBox.Show("Username must be 6 or morre characters long", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValidAccount = false;
            }

            if (tbCreatePassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be 8 or more characters long", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValidAccount = false;
            }

            if (tbCreatePassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Password Does Not Match", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValidAccount = false;
            }

            if (isValidAccount == true)
            {
                if (rbCashierSignin.Checked == true)
                {
                    cashierUsernameSignin = tbCreateUsername.Text;
                    cashierPasswordSignin = tbCreatePassword.Text;
                    MessageBox.Show("Successfully Created A Cashier Account", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    adminUsernameSignin = tbCreateUsername.Text;
                    adminPasswordSignin = tbCreatePassword.Text;
                    MessageBox.Show("Successfully Created An Admin Account", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               
                this.Hide();
                loginPOS.Show();
            }
        }
    }
}
