using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp;

namespace EquationApp.Controllers.Equations
{
    public static class Distance_SUAT
    {
        public static string GetDistance(string initialVelocity, string acceleration, string time)
        {
            decimal U = Convert.ToDecimal(initialVelocity);
            decimal t = Convert.ToDecimal(time);
            decimal a = Convert.ToDecimal(acceleration);

            decimal distance = (U * t) + (a * t * t) / 2;

            return $"{Math.Round(distance, 3).ToString()} m";
        }

        public static string GetInitialVelocity(string distance, string acceleration, string time)
        {
            decimal s = Convert.ToDecimal(distance);
            decimal t = Convert.ToDecimal(time);
            decimal a = Convert.ToDecimal(acceleration);

            decimal initalVelocity = (s - ((a * t * t) / 2)) / t;

            return $"{Math.Round(initalVelocity, 3).ToString()} m/s";
        }

        public static string GetAcceleration(string distance, string time, string initialVelocity)
        {
            decimal s = Convert.ToDecimal(distance);
            decimal U = Convert.ToDecimal(initialVelocity);
            decimal t = Convert.ToDecimal(time);

            decimal acceleration = (2 * (s - (U * t))) / (t * t);

            return $"{Math.Abs(Math.Round(acceleration, 3)).ToString()} m/s^2";
        }

        public static string GetTime(string distance, string initialVelocity, string acceleration)
        {
            decimal s = Convert.ToDecimal(distance);
            decimal U = Convert.ToDecimal(initialVelocity);
            decimal a = Convert.ToDecimal(acceleration);

            decimal x = -a / 2;
            decimal y = -U;
            decimal z = s;

            decimal t1 = -y + Utils.SquareRoot(Math.Round(((y * y) - Convert.ToDecimal(4) * x * z),3)) / (Convert.ToDecimal(2) * x);
            decimal t2 = -y - Utils.SquareRoot(Math.Round(((y * y) - Convert.ToDecimal(4) * x * z), 3)) / (Convert.ToDecimal(2) * x);

            string answer1 =  $"{Math.Round(t1, 3).ToString()}";
            string answer2 = $"{Math.Round(t2, 3).ToString()}";

            return $"{answer1} s OR {answer2} s";
        }
    }
}
