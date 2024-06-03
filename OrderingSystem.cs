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
    public partial class OrderingSystem : Form
    {
        // TODO: Improve the design and layout
        public static string transactionType = "";
        public static double totalPrice = 0, totalInReceipt = 0, VAT = 0;
        public static int orderCounter = 0, orderNo = 0;

        // List para sa receipt
        public static List<int> listOrderNo = new List<int>();
        public static List<int> listQuantity = new List<int>();
        public static List<double> listAmount = new List<double>();
        public static List<double> listVAT = new List<double>();
        public static List<double> listTotalDiscount = new List<double>();
        public static List<double> listTotal = new List<double>();
        public static List<double> listPayment = new List<double>();
        public static List<double> listChange = new List<double>();

        public static bool isSeniorReceipt = false;

        public OrderingSystem()
        {
            InitializeComponent();
        }

        private void btnEnterPrices_Click(object sender, EventArgs e)
        {
            double prices = 0;

            try
            {
                prices = double.Parse(tbEnterPrices.Text);
               

                if (prices > 0 )
                {
                    totalPrice += prices;
                    lbOrders.Items.Add($"Order No. {orderCounter + 1}: {prices}");
                    orderCounter = lbOrders.Items.Count;

                    lblQuantity.Text = orderCounter.ToString();
                    lblTotalPrice.Text = totalPrice.ToString();
                    updateEnterPaymentButton();
                }
                else
                {
                    MessageBox.Show("Price must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tbEnterPrices.Clear();
              
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnEnterPayment_Click(object sender, EventArgs e)
        {
            totalInReceipt = totalPrice;
          
            Receipt receipt = new Receipt();
            payment payment = new payment();
           
            DialogResult isSeniorCitizen = MessageBox.Show("Are you a senior citizen?", "Senior or non-senior", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (isSeniorCitizen == DialogResult.Yes)
            {
                // TODO: Handle the Senior Citizen Information
                seniorTransac seniorTransac = new seniorTransac();

                isSeniorReceipt = true;

                seniorTransac.ShowDialog();
                transactionType = "Senior";

                VAT = 0;
            }
            else
            {
                transactionType = "Non-senior";
                VAT = totalPrice * .12;
                totalPrice += VAT;

                MessageBox.Show($"Total Amount: {totalInReceipt}\n12% VAT: {VAT}\nTotal Amount Add VAT: {totalPrice}", "Updated Price", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSeniorReceipt = false;
                seniorTransac.totalSeniorDiscount = 0;
            }

            if (totalPrice > 0)
            {
                payment.ShowDialog();
            }

            orderNo++;

            receipt.ShowDialog();

            passToList();

            MessageBox.Show("Thank you for ordering!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetData();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cashier Account logged out", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("All data has been cleared", "Data Lost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            resetData();
            this.Hide();
            loginPOS loginPOS = new loginPOS();
            loginPOS.Show();
        }

        private void OrderingSystem_Load(object sender, EventArgs e)
        {
            updateEnterPaymentButton(); 
        }

        private void updateEnterPaymentButton()
        {
            if (orderCounter > 0)
            {
                btnEnterPayment.Enabled = true;
            }
            else
            {
                btnEnterPayment.Enabled = false;
            }
        }

        private void resetData()
        {
            // reset lahat
            lbOrders.Items.Clear();
            lblQuantity.Text = 0.ToString();
            lblTotalPrice.Text = 0.ToString();
            payment.change = 0;
            totalPrice = 0;
            payment.paymentAmount = 0;
            orderCounter = 0;
            seniorTransac.seniorName.Clear();
            seniorTransac.seniorID.Clear();
            seniorTransac.month.Clear();
            seniorTransac.day.Clear();
            seniorTransac.year.Clear();
            seniorTransac.seniorCounter = 0;
            updateEnterPaymentButton();
        }

        private void passToList()
        {
            listOrderNo.Add(orderNo);
            listQuantity.Add(orderCounter);
            listAmount.Add(totalInReceipt);
            listVAT.Add(VAT);
            listTotalDiscount.Add(seniorTransac.totalSeniorDiscount);
            listTotal.Add(totalPrice);
            listPayment.Add(payment.paymentAmount);
            listChange.Add(payment.change);
        }
    }
}
