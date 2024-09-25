using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber.model
{
    internal class Factorial
    {
        public static long CalculateFactorial(int number)
        {
            long factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
