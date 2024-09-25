using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber.model
{
    internal class Factorial
    {
        public static long CalculateFactorial(int num)
        {
            long fact = 1;
            for (int i = num; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
