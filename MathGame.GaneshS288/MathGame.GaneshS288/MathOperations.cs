using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class MathOperations
    {
        internal double Add(double firstNum, double secondNum)
        {
            double result = firstNum + secondNum;
            return result;
        }

        internal double Subtract(double firstNum, double secondNum)
        {
            double result = firstNum - secondNum;
            return result;
        }

        internal double Multiply(double firstNum, double secondNum)
        {
            double result = firstNum * secondNum;
            return result;
        }

        internal double Divide(double firstNum, double secondNum)
        {
            double result = firstNum / secondNum;
            result = double.Truncate(result * 100) / 100;
            return result;
        }
    }
}
