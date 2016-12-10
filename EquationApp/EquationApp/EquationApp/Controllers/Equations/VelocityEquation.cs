using System;

namespace EquationApp.Controllers.Equations
{
    public static class VelocityEquation
    {
        public static string GetVelocity(string userDistance, string userTime)
        {
            decimal distance = Convert.ToDecimal(userDistance);
            decimal time = Convert.ToDecimal(userTime);

            decimal velocity = distance / time;

            return $"{Math.Round(velocity,3).ToString()} m/s";
        }

        public static string GetDistance(string userVelocity, string userTime)
        {
            decimal velocity = Convert.ToDecimal(userVelocity);
            decimal time = Convert.ToDecimal(userTime);

            decimal distance = velocity * time;

            return $"{Math.Round(distance, 3).ToString()} m";
        }

        public static string GetTime(string userVelocity, string userDistance)
        {
            decimal velocity = Convert.ToDecimal(userVelocity);
            decimal distance = Convert.ToDecimal(userDistance);

            decimal time = distance / velocity;

            return $"{Math.Round(time, 3).ToString()} s";
        }
    }
}
