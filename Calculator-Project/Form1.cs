using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Calculator : Form
    {
        calculatorHandler calHandle = new calculatorHandler("0");
        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            calHandle.Add("0");
            resultBox.Text = calHandle.Number;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            calHandle.Add("1");
            resultBox.Text = calHandle.Number;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            calHandle.Add("2");
            resultBox.Text = calHandle.Number;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            calHandle.Add("3");
            resultBox.Text = calHandle.Number;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            calHandle.Add("4");
            resultBox.Text = calHandle.Number;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            calHandle.Add("5");
            resultBox.Text = calHandle.Number;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            calHandle.Add("6");
            resultBox.Text = calHandle.Number;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            calHandle.Add("7");
            resultBox.Text = calHandle.Number;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            calHandle.Add("8");
            resultBox.Text = calHandle.Number;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            calHandle.Add("9");
            resultBox.Text = calHandle.Number;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            calHandle.Cancel();
            resultBox.Text = calHandle.Number;
        }
    }
    class calculatorHandler
    {
        string number;
        public calculatorHandler(string _number = "0")
        {
            number = _number;
        }
        public void Cancel()
        {
            number = "0";
        }
        public void Add(string s)
        {
            if (number == "0")
            {
                number = s;
            }
            else
            {
                number = number + s;
            }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public override string ToString()
        {
            return number;
        }
    }
}
