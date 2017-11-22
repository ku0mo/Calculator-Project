using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{
    class calculatorHandler
    {
        private string number;
        private string operand1;
        private string operand2;
        private string operateState;
        private string decimalNumber;

        public calculatorHandler(string _number = "0")
        {
            number = _number;
            operateState = null;
            operand1 = "0";
            operand2 = null;
            decimalNumber = null;
        }

        public int operate(string cmd)
        {
            switch (cmd) //현재 명령어
            {
                case "＋":
                    if (operand2 != null)
                    {
                        switch (OperateState)
                        {
                            case "＋":
                                operand1 = (double.Parse(operand1) + double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "－":
                                operand1 = (double.Parse(operand1) - double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "×":
                                operand1 = (double.Parse(operand1) * double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "÷":
                                if (operand2 == "0")
                                {
                                    return 0; // 0으로 나누기 하면 0리턴
                                }
                                else
                                {
                                    operand1 = (double.Parse(operand1) / double.Parse(operand2)).ToString();
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
                                operand1 = (double.Parse(operand1) + double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "－":
                                operand1 = (double.Parse(operand1) - double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "×":
                                operand1 = (double.Parse(operand1) * double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "÷":
                                if (operand2 == "0")
                                {
                                    return 0;
                                }
                                else
                                {
                                    operand1 = (double.Parse(operand1) / double.Parse(operand2)).ToString();
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
                                operand1 = (double.Parse(operand1) + double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "－":
                                operand1 = (double.Parse(operand1) - double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "×":
                                operand1 = (double.Parse(operand1) * double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "÷":
                                if (operand2 == "0")
                                {
                                    return 0;
                                }
                                else
                                {
                                    operand1 = (double.Parse(operand1) / double.Parse(operand2)).ToString();
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
                                operand1 = (double.Parse(operand1) + double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "－":
                                operand1 = (double.Parse(operand1) - double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "×":
                                operand1 = (double.Parse(operand1) * double.Parse(operand2)).ToString();
                                operand2 = null;
                                break;
                            case "÷":
                                if (operand2 == "0")
                                {
                                    return 0;
                                }
                                else
                                {
                                    operand1 = (double.Parse(operand1) / double.Parse(operand2)).ToString();
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
                            Number = (double.Parse(operand1) + double.Parse(operand2)).ToString();
                            operand1 = Number;
                            operateState = "=";
                            break;
                        case "－":
                            Number = (double.Parse(operand1) - double.Parse(operand2)).ToString();
                            operand1 = Number;
                            operateState = "=";
                            break;
                        case "×":
                            Number = (double.Parse(operand1) * double.Parse(operand2)).ToString();
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
                                Number = (double.Parse(operand1) / double.Parse(operand2)).ToString();
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
            decimalNumber = "0.";
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
        public string DecimalNumber
        {
            get { return decimalNumber; }
            set { decimalNumber = value; }
        }
        public override string ToString()
        {
            return number;
        }
    }
}
