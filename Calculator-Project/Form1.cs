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
        // 숫자 버튼 관련 이벤트
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
        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            calHandle.Number = resultBox.Text;
        }

        // 연산 관련 버튼 이벤트
        private void btnAdd_Click(object sender, EventArgs e)
        {
            calHandle.operate("＋");
            resultBox.Text = string.Format("{0} + ", calHandle.Operand1);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calHandle.operate("－");
            resultBox.Text = string.Format("{0} - ", calHandle.Operand1);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calHandle.operate("×");
            resultBox.Text = string.Format("{0} × ", calHandle.Operand1);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calHandle.operate("÷");
            resultBox.Text = string.Format("{0} ÷ ", calHandle.Operand1);
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            calHandle.operate("=");
            calHandle.Operand2 = "0";
            resultBox.Text = calHandle.Number;
        }
    }
    class calculatorHandler
    {
        private string number;
        private string operand1;
        private string operand2;
        private string operateState;
        public calculatorHandler(string _number = "0")
        {
            number = _number;
            operateState = null;
            operand1 = "0";
            operand2 = "0";
        }
        public void operate(string cmd)
        {
            switch(cmd)
            {
                case "＋":
                    operand1 = number;
                    operateState = "＋";
                    break;
                case "－":
                    operand1 = number;
                    operateState = "－";
                    break;
                case "×":
                    operand1 = number;
                    operateState = "×";
                    break;
                case "÷":
                    operand1 = number;
                    operateState = "÷";
                    break;
                case "=":
                    switch (operateState)
                    {
                        case "＋":
                            Number = (long.Parse(operand1) + long.Parse(operand2)).ToString();
                            operand1 = Number;
                            operateState = "=";
                            break;
                        case "－":
                            Number = (long.Parse(operand1) - long.Parse(operand2)).ToString();
                            operand1 = Number;
                            operateState = "=";
                            break;
                        case "×":
                            Number = (long.Parse(operand1) * long.Parse(operand2)).ToString();
                            operand1 = Number;
                            operateState = "=";
                            break;
                        case "÷":
                            Number = (long.Parse(operand1) / long.Parse(operand2)).ToString();
                            operand1 = Number;
                            operateState = "=";
                            break;
                    }
                    break;
            }
        }
        public void Cancel()
        {
            number = "0";
            operand1 = "0";
            operand2 = "0";
        }
        public string Add(string s)
        {
            if (operateState == "=" || operateState == null)
            {
                if (number == "0")
                {
                    number = s;
                }
                else
                {
                    number = number + s;
                }
                return number;
            }
            else
            {
                if (operand2 == "0")
                {
                    operand2 = s;
                }
                else
                {
                    operand2 = operand2 + s;
                }
                return operand2;
            }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Operand1
        {
            get { return operand1; }
            set { operand1 = value; }
        }
        public string Operand2
        {
            get { return operand2; }
            set { operand2 = value; }
        }
        public override string ToString()
        {
            return number;
        }
    }
}
