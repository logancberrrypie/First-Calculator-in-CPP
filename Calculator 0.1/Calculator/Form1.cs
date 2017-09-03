using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class TextBox : Form
    {
        double total = 0;
        string operationPerformed = "";
        bool isoperationPerformed = false;
        bool isdecimal = false;

        public TextBox()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Result.Text = "0";
            total = 0;
            operationPerformed = "";
            isoperationPerformed = false;
            label1.Text = "";
            isdecimal = false;
        }

        private void TextBox_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            editResult("1");
        }

        private void Digit2_Click(object sender, EventArgs e)
        {
            editResult("2");
        }

        private void Digit3_Click(object sender, EventArgs e)
        {
            editResult("3");
        }

        private void Digit4_Click(object sender, EventArgs e)
        {
            editResult("4");
        }

        private void Digit5_Click(object sender, EventArgs e)
        {
            editResult("5");
        }

        private void Digit6_Click(object sender, EventArgs e)
        {
            editResult("6");
        }

        private void Digit7_Click(object sender, EventArgs e)
        {
            editResult("7");
        }

        private void Digit8_Click(object sender, EventArgs e)
        {
            editResult("8");
        }

        private void Digit9_Click(object sender, EventArgs e)
        {
            editResult("9");
        }

        private void Digit0_Click(object sender, EventArgs e)
        {
            editResult("0");
        }

        public void editResult(string text)
        {
            if ((Result.Text == "0") || (isoperationPerformed))
            {
                Result.Text = "";
            }
            Result.Text = Result.Text + text;
            isoperationPerformed = false;
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        public void Operator_changed(object sender)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            total = Convert.ToDouble(Result.Text);
            label1.Text = total + " " + operationPerformed;
            isoperationPerformed = true;
            isdecimal = false;
        }

        private void OperationAdd_Click(object sender, EventArgs e)
        {
            Operator_changed(sender);
        }

        private void OperationSubtract_Click(object sender, EventArgs e)
        {
            Operator_changed(sender);
        }

        private void OperationMultiply_Click(object sender, EventArgs e)
        {
            Operator_changed(sender);
        }

        private void OperationDivide_Click(object sender, EventArgs e)
        {
            Operator_changed(sender);
        }

        private void OperationEquals_Click(object sender, EventArgs e)
        {
            isdecimal = false;
            label1.Text = "";
            switch (operationPerformed)
            {
                case "+":
                    Result.Text = Convert.ToString(total + Convert.ToDouble(Result.Text));
                    break;
                case "-":
                    Result.Text = Convert.ToString(total - Convert.ToDouble(Result.Text));
                    break;
                case "*":
                    Result.Text = Convert.ToString(total * Convert.ToDouble(Result.Text));
                    break;
                case "/":
                    if (Convert.ToDouble(Result.Text)==0)
                        {
                        MessageBox.Show("Invalid operation.Cannot divide by 0");
                        break;
                    }
                    else {
                        Result.Text = Convert.ToString(total / Convert.ToDouble(Result.Text));
                        break;
                    }
                    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OperationDecimal_Click(object sender, EventArgs e)
        {
            if (!isdecimal)
            {
                if (Result.Text == "0")
                {
                    Result.Text = "0.";
                }else
                {
                    editResult(".");
                    
                }
                isoperationPerformed = false;
                isdecimal = true;

            }
            else
            {
                MessageBox.Show("Invalid input.Cannot have more than one decimal (.)");
            }

        }
    }
}
