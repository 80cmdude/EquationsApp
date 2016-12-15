using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp.Controllers.Equations
{
    public static class Velocity_VUAT
    {
        public static string getFinalVelocity(string initialVelocity, string acceleration, string time)
        {
            decimal u = Convert.ToDecimal(initialVelocity);
            decimal a = Convert.ToDecimal(acceleration);
            decimal t =  Convert.ToDecimal(time);

            decimal finalVelocity = u + (a * t);

            return $"{Math.Round(finalVelocity, 3)} m/s";
        }

        public static string getInitialVelocity(string finalVelocity, string acceleration, string time)
        {
            decimal v = Convert.ToDecimal(finalVelocity);
            decimal a = Convert.ToDecimal(acceleration);
            decimal t = Convert.ToDecimal(time);

            decimal initialVelocity = v - (a * t);

            return $"{Math.Round(initialVelocity, 3)} m/s";
        }

        public static string getAcceleration(string finalVelocity, string initialVelocity, string time)
        {
            decimal v = Convert.ToDecimal(finalVelocity);
            decimal u = Convert.ToDecimal(initialVelocity);
            decimal t = Convert.ToDecimal(time);

            decimal acceleration = (v - u) / t;

            return $"{Math.Round(acceleration, 3)} m/s^2";
        }

        public static string getTime(string finalVelocity, string intialVelocity, string acceleration)
        {
            decimal v = Convert.ToDecimal(finalVelocity);
            decimal u = Convert.ToDecimal(intialVelocity);
            decimal a = Convert.ToDecimal(acceleration);

            decimal time = (v - u) / a;

            return $"{Math.Round(time, 3)} s";
        }
    }
}
