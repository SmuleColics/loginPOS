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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            if (OrderingSystem.isSeniorReceipt == true)
            {
                int index = 0;

                foreach (string name in seniorTransac.seniorName)
                {
                    lbReceipt.Items.Add($"Senior Citizen Name: {name}");
                    lbReceipt.Items.Add($"Senior ID Number: {seniorTransac.seniorID[index]}");
                    index++;
                }

                lbReceipt.Items.Add($"Quantity: {OrderingSystem.orderCounter}");
                lbReceipt.Items.Add($"Amount: {OrderingSystem.totalInReceipt}");
                lbReceipt.Items.Add($"Total Senior Discount: {seniorTransac.totalSeniorDiscount}");
                lbReceipt.Items.Add($"Total Amount Less Discount: {OrderingSystem.totalPrice}");
            }
            else
            {
                lbReceipt.Items.Add($"Quantity: {OrderingSystem.orderCounter}");
                lbReceipt.Items.Add($"Amount: {OrderingSystem.totalInReceipt}");
                lbReceipt.Items.Add($"12% VAT: {OrderingSystem.VAT}");
                lbReceipt.Items.Add($"Total Amount Add VAT: {OrderingSystem.totalPrice}");
            }

            lbReceipt.Items.Add($"Cash Tendered: {payment.paymentAmount}");
            lbReceipt.Items.Add($"Change: {payment.change}");

        }
    }
}
