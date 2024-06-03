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
    public partial class seniorTransac : Form
    {

        public static List<string> seniorName = new List<string>();
        public static List<string> seniorID = new List<string>();
        public static List<int> month = new List<int>();
        public static List<int> day = new List<int>();
        public static List<int> year = new List<int>();

        public static double totalAmount = 0, VAT = 0, VATExemptPrice = 0, seniorDiscount = 0, totalSeniorDiscount = 0;
        public static int seniorCounter = 0;

        public bool allowedToFinish = false;

        public seniorTransac()
        {
            InitializeComponent();
        }

        private void submitSeniorButton_Click(object sender, EventArgs e)
        {
            bool continueSenior = true;

            if (tbSeniorName.Text.Length < 1)
            {
                MessageBox.Show("Enter a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                continueSenior = false;
            }

            // assume na 3 number lang ang minimum
            if (tbIDNumber.Text.Length < 2)
            {
                MessageBox.Show("Enter a valid ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                continueSenior = false;
            }

            int monthTry = 0, dayTry = 0, yearTry = 0;

            try
            {
                monthTry = Int32.Parse(tbMonths.Text);
                dayTry = Int32.Parse(tbDays.Text);
                yearTry = Int32.Parse(tbYears.Text);

                if (monthTry > 12 || monthTry < 1)
                {
                    MessageBox.Show("Enter a valid month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continueSenior = false;
                }
                if (dayTry > 31 || dayTry < 1)
                {
                    MessageBox.Show("Enter a valid day", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continueSenior = false;
                }
                if (yearTry > 1964)
                {
                    // 60 years ago, 1964
                    MessageBox.Show("You must be greater or equal to 60 year old","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continueSenior = false;
                }
                if (yearTry < 1900)
                {
                    // patay ka na siguro nyan
                    MessageBox.Show("1900 is the limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continueSenior = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid time format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                continueSenior = false;
            }

            if (continueSenior == true)
            {
                seniorName.Add(tbSeniorName.Text);
                seniorID.Add(tbIDNumber.Text);
                month.Add(monthTry);
                day.Add(dayTry);
                year.Add(yearTry);
                allowedToFinish = true;
                seniorCounter++;
                MessageBox.Show("Successfully submitted the information", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSeniorName.Clear();
                tbIDNumber.Clear();
                tbMonths.Clear();
                tbDays.Clear();
                tbYears.Clear();
            }

        }


        private void finishSeniorButton_Click(object sender, EventArgs e)
        {
            if (tbSeniorName.Text.Length > 1 || tbIDNumber.Text.Length > 1 || tbMonths.Text.Length > 1 || tbDays.Text.Length > 1 || tbYears.Text.Length > 1)
            {
                MessageBox.Show("Click the submit button to submit all the information", "Submit Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                double limit = 500;

                if (allowedToFinish == true)
                {
                    totalAmount = OrderingSystem.totalPrice;
                    VAT = limit * .12;
                    VATExemptPrice = limit - VAT;
                    seniorDiscount = VATExemptPrice * .20;
                    totalSeniorDiscount = (VAT + seniorDiscount) * seniorCounter;
                    OrderingSystem.totalPrice = totalAmount - totalSeniorDiscount;

                    if (totalSeniorDiscount > totalAmount)
                    {
                        OrderingSystem.totalPrice = 0;
                    }

                    MessageBox.Show($"Total Amount: {totalAmount}\nTotal Senior Discount: {totalSeniorDiscount}\nTotal Less Discount: {OrderingSystem.totalPrice}", "Updated Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please fill out all the necessary information","Fill up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }
    }
}
