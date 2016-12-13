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
    }
}
