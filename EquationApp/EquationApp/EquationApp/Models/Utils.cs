using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Models;

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

        /// <summary>
        /// Don't need to convert number to double
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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

    public class UtilsNS
    {
        /// <summary>
        /// x^2 + x + C = 0
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Object with both values</returns>
        public Qaudratic SolveQuadratic(decimal a, decimal b, decimal c)
        {
            decimal derivitive = (b * b) - (Convert.ToDecimal(4) * a * c);
            decimal rootDerivitive = Utils.SquareRoot(derivitive);
            decimal x1 = (-b + rootDerivitive) / (Convert.ToDecimal(2) * a);
            decimal x2 = (-b - rootDerivitive) / (Convert.ToDecimal(2) * a);

            Qaudratic quad = new Qaudratic();
            quad.answer1 = Math.Round(x1,3);
            quad.answer2 = Math.Round(x2,3);
            return quad;
        }
    }

}
