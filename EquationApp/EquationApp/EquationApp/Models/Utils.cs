using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp
{
    public static class Utils
    {
        public static decimal Divide(string numerator, string denominator)
        {
            decimal x = Convert.ToDecimal(numerator);
            decimal y = Convert.ToDecimal(denominator);

            return x / y;
        }

        public static decimal Multiply(string first, string second)
        {
            decimal x = Convert.ToDecimal(first);
            decimal y = Convert.ToDecimal(second);

            return x * y;
        }

        public static decimal SquareRoot(decimal number)
        {
            decimal sqrt = 0;
            decimal tempNumber1, tempNumber2;
            decimal e = 0.00000000000000000001m;

            sqrt = number;
            tempNumber2 = sqrt * sqrt;

            while (tempNumber2 - number >= e)
            {
                tempNumber1 = (sqrt + (number / sqrt)) / 2;
                sqrt = tempNumber1;
                tempNumber2 = sqrt * sqrt;
            }

            return sqrt;
        }
    }
}
