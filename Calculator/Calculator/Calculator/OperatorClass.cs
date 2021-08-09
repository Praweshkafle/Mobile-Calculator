using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
   public static class OperatorClass
    {
        public static double Result;
        public static double GetSymbol(string sign, double FirstNum, double SecondNum)
        {
            switch (sign)
            {
                case "+":
                    Result = FirstNum + SecondNum;
                    break;
                case "-":
                    Result = FirstNum - SecondNum;
                    break;
                case "/":
                    Result = FirstNum / SecondNum;
                    break;
                case "*":
                    Result = FirstNum * SecondNum;
                    break;

                default:
                    break;
            }
            return Result;
        }
    }
}
