using System;

namespace EquationApp.Controllers.Equations
{
    public static class VelocityEquation
    {
        public static decimal GetVelocity(string userDistance, string userTime)
        {
            decimal distance = Convert.ToDecimal(userDistance);
            decimal time = Convert.ToDecimal(userTime);

            decimal velocity = distance / time;

            return Math.Round(velocity,3);
        }

        public static decimal GetDistance(string userVelocity, string userTime)
        {
            decimal velocity = Convert.ToDecimal(userVelocity);
            decimal time = Convert.ToDecimal(userTime);

            decimal distance = velocity * time;

            return Math.Round(distance, 3);
        }

        public static decimal GetTime(string userVelocity, string userDistance)
        {
            decimal velocity = Convert.ToDecimal(userVelocity);
            decimal distance = Convert.ToDecimal(userDistance);

            decimal time = distance / velocity;

            return Math.Abs(Math.Round(time, 3));
        }
    }
}
