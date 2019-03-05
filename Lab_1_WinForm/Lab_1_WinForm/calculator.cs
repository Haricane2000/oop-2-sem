using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_WinForm
{
    class calculator
    {
        public static int Add(int a1, int a2)
        {
            return a1 + a2;
        }

        public static int Sub(int a1, int a2)
        {
            return a1 - a2;
        }

        public static Double Div(Double a1, Double a2)
        {
            if (a2 == 0)
                throw new System.DivideByZeroException();
            else
                return a1 / a2;

        }

        public static int Mult(int a1, int a2)
        {
            return a1 * a2;
        }

        public static Double Equally(Double a1, Double a2)
        {
            return a1 = a2;
        }

        public static int Div2(int a1, int a2)
        {
            return a1 % a2;
        }
    }
}
