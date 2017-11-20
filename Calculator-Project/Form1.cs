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
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            calHandle.Add("1");

            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            calHandle.Add("2");

            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            calHandle.Add("3");

            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            calHandle.Add("4");

            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            calHandle.Add("5");

            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            calHandle.Add("6");

            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            calHandle.Add("7");

            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            calHandle.Add("8");

            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            calHandle.Add("9");

            resultBox.Text = calHandle.Number;
            if (calHandle.Operand2 != null)
            {
                resultBox.Text = string.Format("{0} {1} {2}", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
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
            if( calHandle.Operand2 == null)
            {
                operateCount++;
            }
            if(operateCount == 2)
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
                calHandle.Operand1 = ((long.Parse(calHandle.Number) * (-1)).ToString());
                resultBox.Text = calHandle.Operand1;
            }
            else if(calHandle.Operand2 == null)
            {
                return;
            }
            else
            {
                calHandle.Operand2 = ((long.Parse(calHandle.Operand2) * (-1)).ToString());
                resultBox.Text = string.Format("{0} {1} ({2})", calHandle.Operand1, calHandle.OperateState, calHandle.Operand2);
            }
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
            operand2 = null;
        }

        public int operate(string cmd)
        {
            switch(cmd) //현재 명령어
            {
                case "＋":
                    if( operand2 != null)
                    {
                        switch(OperateState)
                        {
                            case "＋":
                                operand1 = (long.Parse(operand1) + long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "－":
                                operand1 = (long.Parse(operand1) - long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "×":
                                operand1 = (long.Parse(operand1) * long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "÷":
                                if (operand2 == "0")
                                {
                                    return 0; // 0으로 나누기 하면 0리턴
                                }
                                else
                                {
                                    operand1 = (long.Parse(operand1) / long.Parse(operand2)).ToString();
                                    operand2 = null;
                                }
                                break;
                        }
                    }
                    else
                    {
                        operand1 = number;
                    }
                    break;
                case "－":
                    if (operand2 != null)
                    {
                        switch (OperateState)
                        {
                            case "＋":
                                operand1 = (long.Parse(operand1) + long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "－":
                                operand1 = (long.Parse(operand1) - long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "×":
                                operand1 = (long.Parse(operand1) * long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "÷":
                                if (operand2 == "0")
                                {
                                    return 0;
                                }
                                else
                                {
                                    operand1 = (long.Parse(operand1) / long.Parse(operand2)).ToString();
                                    operand2 = null;
                                }
                                break;
                        }

                    }
                    else
                    {
                        operand1 = number;
                    }
                    break;
                case "×":
                    if (operand2 != null)
                    {
                        switch (OperateState)
                        {
                            case "＋":
                                operand1 = (long.Parse(operand1) + long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "－":
                                operand1 = (long.Parse(operand1) - long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "×":
                                operand1 = (long.Parse(operand1) * long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "÷":
                                if (operand2 == "0")
                                {
                                    return 0;
                                }
                                else
                                {
                                    operand1 = (long.Parse(operand1) / long.Parse(operand2)).ToString();
                                    operand2 = null;
                                }
                                break;
                        }

                    }
                    else
                    {
                        operand1 = number;
                    }
                    break;
                case "÷":
                    if (operand2 != null)
                    {
                        switch (OperateState)
                        {
                            case "＋":
                                operand1 = (long.Parse(operand1) + long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "－":
                                operand1 = (long.Parse(operand1) - long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "×":
                                operand1 = (long.Parse(operand1) * long.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "÷":
                                if (operand2 == "0")
                                {
                                    return 0;
                                }
                                else
                                {
                                    operand1 = (long.Parse(operand1) / long.Parse(operand2)).ToString();
                                    operand2 = null;
                                }
                                break;
                        }

                    }
                    else
                    {
                        operand1 = number;
                    }
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
                            if (Operand2 == "0")
                            {
                                return 0;
                            }
                            else
                            {
                                Number = (long.Parse(operand1) / long.Parse(operand2)).ToString();
                                operand1 = Number;
                                operateState = "=";
                            }
                            break;
                    }
                    break;
            }
            return 1;
        }
        public void Cancel()
        {
            number = "0";
            operand1 = "0";
            operand2 = null;
            operateState = null;
        }
        public void Add(string s)
        {
            if (operateState == "=" || operateState == null) // 결과 or 처음
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
            else  // 사칙연산이 눌려진 상태
            {
                if (operand2 == null)
                {
                    operand2 = s;
                }
                else
                {
                    operand2 = operand2 + s;
                }
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
        public string OperateState
        {
            get { return operateState; }
            set { operateState = value; }
        }
        public override string ToString()
        {
            return number;
        }
    }
}
