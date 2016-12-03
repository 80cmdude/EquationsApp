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

            return Math.Round(velocity,3).ToString();
        }
    }
}
