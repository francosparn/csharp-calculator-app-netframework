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
    public partial class MainForm : Form
    {
        // Global variables
        double NumberOne = 0;
        double NumberTwo = 0;
        char Operator;

        public MainForm()
        {
            InitializeComponent();
        }

        private void addNumber(object sender, EventArgs e)
        {
            var btn = ((Button)sender);

            if(txtResult.Text == "0")
            {
                txtResult.Text = "";
            }
                txtResult.Text += btn.Text;
        }

        private void clickOperator(object sender, EventArgs e)
        {
            var btn = ((Button)sender);

            NumberOne = Convert.ToDouble(txtResult.Text);
            Operator = Convert.ToChar(btn.Tag);

            if (Operator == '√')
            {
                NumberOne = Math.Sqrt(NumberOne);
                txtResult.Text = NumberOne.ToString();
            } else if (Operator == '²')
            {
                NumberOne = Math.Pow(NumberOne, 2);
                txtResult.Text = NumberOne.ToString();
            } else
            {
                txtResult.Text = "0";
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(txtResult.Text);
            Operator = '+';
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            NumberTwo = Convert.ToDouble(txtResult.Text);

            if(Operator == '+')
            {
                txtResult.Text = (NumberOne + NumberTwo).ToString();
                NumberOne = Convert.ToDouble(txtResult.Text);
            } else if(Operator == '-')
            {
                txtResult.Text = (NumberOne - NumberTwo).ToString();
                NumberOne = Convert.ToDouble(txtResult.Text);
            } else if(Operator == 'x')
            {
                txtResult.Text = (NumberOne * NumberTwo).ToString();
                NumberOne = Convert.ToDouble(txtResult.Text);
            } else if(Operator == '÷')
            {
                txtResult.Text = (NumberOne / NumberTwo).ToString();
                NumberOne = Convert.ToDouble(txtResult.Text);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtResult.Text = "0";
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            NumberOne = 0;
            NumberTwo = 0;
            Operator = '\0';
            txtResult.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(txtResult.Text);
            NumberOne *= -1;
            txtResult.Text = NumberOne.ToString();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            NumberTwo = Convert.ToDouble(txtResult.Text);

            var resultPercent = Convert.ToDouble((NumberOne * NumberTwo / 100));

            txtResult.Text = resultPercent.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
