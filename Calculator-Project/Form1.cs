﻿using System;
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
        void PrintMemoryBox() //연산 눌렀을 경우 메모리박스에 출력
        {
            if (calHandle.Operand2 != null)
            {
                memoryBox.Text += string.Format("{0}", calHandle.Operand2) ;

                if (calHandle.OperateState != "=" && calHandle.OperateState != null)
                { //연속 계산 시
                    memoryBox.Text += string.Format("{0}", calHandle.OperateState);
                    resultBox.Text = calHandle.Operand1;
                }

                    calHandle.Operand2 = null;
            }
            else
            {
                memoryBox.Text += calHandle.Operand1 + string.Format("{0}", calHandle.OperateState);
            }

            if (calHandle.OperateState == "=") // = 클릭했을 때
            {
                memoryBox.Text += "-------------------------" + Environment.NewLine;
                memoryBox.Text += "=";
                memoryBox.Text += resultBox.Text + Environment.NewLine + Environment.NewLine + Environment.NewLine;
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
            btnEqual.Focus();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            calHandle.Add("1");
            PrintOperandResult();
            btnEqual.Focus();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            calHandle.Add("2");
            PrintOperandResult();
            btnEqual.Focus();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            calHandle.Add("3");
            PrintOperandResult();
            btnEqual.Focus();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            calHandle.Add("4");
            PrintOperandResult();
            btnEqual.Focus();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            calHandle.Add("5");
            PrintOperandResult();
            btnEqual.Focus();
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            calHandle.Add("6");
            PrintOperandResult();
            btnEqual.Focus();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            calHandle.Add("7");
            PrintOperandResult();
            btnEqual.Focus();
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            calHandle.Add("8");
            PrintOperandResult();
            btnEqual.Focus();
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            calHandle.Add("9");
            PrintOperandResult();
            btnEqual.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            calHandle.Cancel();
            operateCount = 0;
            resultBox.Text = calHandle.Number;
            btnEqual.Focus();
        }
        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            calHandle.Number = resultBox.Text;
            btnEqual.Focus();
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
                PrintMemoryBox();
            }
            btnEqual.Focus();
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
                PrintMemoryBox();
            }
            btnEqual.Focus();
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
                PrintMemoryBox();
            }
            btnEqual.Focus();
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
                PrintMemoryBox();

            }
            btnEqual.Focus();
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
                resultBox.Text = calHandle.Number;
            }
            operateCount = 0;
            PrintMemoryBox();
            calHandle.OperateState = null;
            calHandle.Cancel();
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
            btnEqual.Focus();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (calHandle.Operand2 == null)
            {
                for (int i = 0; i < calHandle.Number.Length; ++i)
                {
                    if (calHandle.Number[i] == '.')
                    {
                        return;
                    }
                }
                calHandle.Number += ".";
                resultBox.Text = calHandle.Number;
            }
            else
            {
                for (int i = 0; i < calHandle.Operand2.Length; ++i)
                {
                    if (calHandle.Operand2[i] == '.')
                    {
                        return;
                    }
                }
                calHandle.Operand2 += '.';
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
            btnEqual.Focus();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)48:
                    btn0_Click(sender, e);
                    break;
                case (char)49:
                    btn1_Click(sender, e);
                    break;
                case (char)50:
                    btn2_Click(sender, e);
                    break;
                case (char)51:
                    btn3_Click(sender, e);
                    break;
                case (char)52:
                    btn4_Click(sender, e);
                    break;
                case (char)53:
                    btn5_Click(sender, e);
                    break;
                case (char)54:
                    btn6_Click(sender, e);
                    break;
                case (char)55:
                    btn7_Click(sender, e);
                    break;
                case (char)56:
                    btn8_Click(sender, e);
                    break;
                case (char)57:
                    btn9_Click(sender, e);
                    break;
                case 96:
                    btn0_Click(sender, e);
                    break;
                case 97:
                    btn1_Click(sender, e);
                    break;
                case 98:
                    btn2_Click(sender, e);
                    break;
                case 99:
                    btn3_Click(sender, e);
                    break;
                case 100:
                    btn4_Click(sender, e);
                    break;
                case 101:
                    btn5_Click(sender, e);
                    break;
                case 102:
                    btn6_Click(sender, e);
                    break;
                case 103:
                    btn7_Click(sender, e);
                    break;
                case 104:
                    btn8_Click(sender, e);
                    break;
                case 105:
                    btn9_Click(sender, e);
                    break;
                case 107:
                    btnAdd_Click(sender, e);
                    break;
                case 109:
                    btnSubtract_Click(sender, e);
                    break;
                case 106:
                    btnMultiply_Click(sender, e);
                    break;
                case 111:
                    btnDivide_Click(sender, e);
                    break;
                case 13:
                    btnEqual_Click(sender, e);
                    break;
                case 110:
                    btnDot_Click(sender, e);
                    break;
                case 8:
                    btnCancel_Click(sender, e);
                    break;

            }
        }
    }

}