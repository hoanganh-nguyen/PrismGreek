using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class CalculatorService:ICalculatorService
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}
