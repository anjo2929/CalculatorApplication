using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtBoxInput1.Text);
                double num2 = Convert.ToDouble(txtBoxInput2.Text);
                string op = cbOperator.SelectedItem.ToString();

                CalculatorClass cal = new CalculatorClass(); // Instantiate CalculatorClass

                if (op == "+")
                {
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                }
                else if (op == "-")
                {
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                }
                else if (op == "*")
                {
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                }
                else if (op == "/")
                {
                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                }
                else
                {
                    lblDisplayTotal.Text = "Select a operator";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numbers");
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid or lacking of Arithmetic Operators");
            }

        }
    }

}