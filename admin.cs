using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPOS
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            int indexNo = 0;

            lblUsername.Text = loginPOS.usernameLogin;

            foreach (int orderNumber in OrderingSystem.listOrderNo)
            {
                lbOrderNo.Items.Add(orderNumber);
                lbQuantity.Items.Add(OrderingSystem.listQuantity[indexNo]);
                lbAmount.Items.Add(OrderingSystem.listAmount[indexNo]);
                lbVAT.Items.Add(OrderingSystem.listVAT[indexNo]);
                lbTotalDiscount.Items.Add(OrderingSystem.listTotalDiscount[indexNo]);
                lbTotal.Items.Add(OrderingSystem.listTotal[indexNo]);
                lbPayment.Items.Add(OrderingSystem.listPayment[indexNo]);
                lbChange.Items.Add(OrderingSystem.listChange[indexNo]);
                indexNo++;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginPOS loginPOS = new loginPOS();
            MessageBox.Show("Admin Account logged out", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            loginPOS.Show();
        }
    }
}
