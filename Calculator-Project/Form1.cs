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
        static int operateCount = 0;
        void PrintOperandResult()
        {
            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
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
            PrintOperandResult();

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            calHandle.Add("1");
            PrintOperandResult();

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            calHandle.Add("2");
            PrintOperandResult();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            calHandle.Add("3");

            PrintOperandResult();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            calHandle.Add("4");
            PrintOperandResult();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            calHandle.Add("5");
            PrintOperandResult();
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            calHandle.Add("6");
            PrintOperandResult();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            calHandle.Add("7");
            PrintOperandResult();
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            calHandle.Add("8");
            PrintOperandResult();
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            calHandle.Add("9");
            PrintOperandResult();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            calHandle.Cancel();
            operateCount = 0;
            resultBox.Text = calHandle.Number;
        }
        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            calHandle.Number = resultBox.Text;
        }

        // 연산 관련 버튼 이벤트 //

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (calHandle.Operand2 == null)
            {
                operateCount++;
            }
            if (operateCount == 2)
            {
                resultBox.Text = "연산이 바뀌었습니다.";
                calHandle.Cancel();
                operateCount = 0;
                return;
            }
            int isZero = calHandle.operate("＋");
            if (isZero == 0)
            {
                resultBox.Text = "0으로 나눌 수 없습니다.";
                calHandle.Cancel();
            }
            else
            {
                resultBox.Text = string.Format("{0} + ", calHandle.Operand1);
                calHandle.OperateState = "＋";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (calHandle.Operand2 == null)
            {
                operateCount++;
            }
            if (operateCount == 2)
            {
                resultBox.Text = "연산이 바뀌었습니다.";
                calHandle.Cancel();
                operateCount = 0;

                return;
            }
            int isZero = calHandle.operate("－");
            if (isZero == 0)
            {
                resultBox.Text = "0으로 나눌 수 없습니다.";
                calHandle.Cancel();
            }
            else
            {
                resultBox.Text = string.Format("{0} - ", calHandle.Operand1);
                calHandle.OperateState = "－";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (calHandle.Operand2 == null)
            {
                operateCount++;
            }
            if (operateCount == 2)
            {
                resultBox.Text = "연산이 바뀌었습니다.";
                calHandle.Cancel();
                operateCount = 0;

                return;
            }
            int isZero = calHandle.operate("×");
            if (isZero == 0)
            {
                resultBox.Text = "0으로 나눌 수 없습니다.";
                calHandle.Cancel();
            }
            else
            {
                resultBox.Text = string.Format("{0} × ", calHandle.Operand1);
                calHandle.OperateState = "×";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (calHandle.Operand2 == null)
            {
                operateCount++;
            }
            if (operateCount == 2)
            {
                resultBox.Text = "연산이 바뀌었습니다.";
                calHandle.Cancel();
                operateCount = 0;

                return;
            }
            int isZero = calHandle.operate("÷");
            if (isZero == 0)
            {
                resultBox.Text = "0으로 나눌 수 없습니다.";
                calHandle.Cancel();
            }
            else
            {
                resultBox.Text = string.Format("{0} ÷ ", calHandle.Operand1);
                calHandle.OperateState = "÷";

            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int isZero = calHandle.operate("=");
            if (isZero == 0)
            {
                resultBox.Text = "0으로 나눌 수 없습니다.";
                calHandle.Cancel();
            }
            else
            {
                calHandle.Operand2 = null;
                resultBox.Text = calHandle.Number;
            }
            operateCount = 0;
            calHandle.OperateState = null;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (calHandle.OperateState == null)
            {
                calHandle.Operand1 = ((double.Parse(calHandle.Number) * (-1)).ToString());
                resultBox.Text = calHandle.Operand1;
            }
            else if (calHandle.Operand2 == null)
            {
                return;
            }
            else // operand2 부호 전환
            {
                calHandle.Operand2 = ((double.Parse(calHandle.Operand2) * (-1)).ToString());
                resultBox.Text = string.Format("{0} {1} ({2})", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < calHandle.Number.Length; ++i)
            {
                if(calHandle.Number[i] == '.')
                {
                    return;
                }
            }
            calHandle.Number += ".";
            resultBox.Text = calHandle.Number;
        }
    }
    
}
