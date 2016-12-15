using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp;
using EquationApp.Models;

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
            decimal s = -Convert.ToDecimal(distance);
            decimal U = Convert.ToDecimal(initialVelocity);
            decimal a = Convert.ToDecimal(acceleration);

            if (a == 0)
            {
                decimal answer = -s / U;
                return $"{answer} s";
            }
            else
            {
                UtilsNS helper = new UtilsNS();
                Qaudratic quad = helper.SolveQuadratic(a, U, s);

                if (quad.answer1 == quad.answer2)
                {
                    return $"{quad.answer1} s";
                }
                else if (quad.answer1 <= 0)
                {
                    return $"{quad.answer2} s";
                }
                else if (quad.answer2 <= 0)
                {
                    return $"{quad.answer1} s";
                }
                else
                {
                    return $"{quad.answer1} s OR {quad.answer2} s";
                }
            }
        }
    }
}
