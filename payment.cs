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
    public partial class payment : Form
    {
        public static double paymentAmount = 0, totalAmount = 0, change = 0;

        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            // para di ma exit yung payment
            ControlBox = false;

            lblTransactionType.Text = OrderingSystem.transactionType;
            double labelTotalPrice = OrderingSystem.totalPrice;
            lblTotalPrice.Text = labelTotalPrice.ToString();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            double TotalPrice = OrderingSystem.totalPrice;
           
            try
            {
                paymentAmount = Convert.ToDouble(tbPayment.Text);

                if (paymentAmount >= TotalPrice)
                {
                    change = paymentAmount - TotalPrice;

                    MessageBox.Show("Paid", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Insufficient Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
