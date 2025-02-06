using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment1
{
    public class Calculator
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }
        public double Subtraction(double x, double y)
        {
            return x - y;
        }
        public double Multiplication(double x, double y)
        {
            return x * y;
        }
        public double Division(double x, double y)
        {
            if(y==0)
            {
                throw new DivideByZeroException("We cannot divide by zero");
            }
            return x / y;
        }
    }
}
