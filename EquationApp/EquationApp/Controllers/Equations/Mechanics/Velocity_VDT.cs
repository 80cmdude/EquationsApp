using System;

namespace EquationApp.Controllers.Equations
{
    public static class Velocity_VDT
    {
        /// <summary>
        /// V = d / t
        /// </summary>
        /// <param name="userDistance"></param>
        /// <param name="userTime"></param>
        /// <returns>Decimal</returns>
        public static decimal GetVelocity(string userDistance, string userTime)
        {
            decimal distance = Convert.ToDecimal(userDistance);
            decimal time = Convert.ToDecimal(userTime);

            decimal velocity = distance / time;

            return Math.Round(velocity,3);
        }

        /// <summary>
        /// d = V * t
        /// </summary>
        /// <param name="userVelocity"></param>
        /// <param name="userTime"></param>
        /// <returns></returns>
        public static decimal GetDistance(string userVelocity, string userTime)
        {
            decimal velocity = Convert.ToDecimal(userVelocity);
            decimal time = Convert.ToDecimal(userTime);

            decimal distance = velocity * time;

            return Math.Round(distance, 3);
        }

        /// <summary>
        /// t = d / V
        /// </summary>
        /// <param name="userVelocity"></param>
        /// <param name="userDistance"></param>
        /// <returns></returns>
        public static decimal GetTime(string userVelocity, string userDistance)
        {
            decimal velocity = Convert.ToDecimal(userVelocity);
            decimal distance = Convert.ToDecimal(userDistance);

            decimal time = distance / velocity;

            return Math.Abs(Math.Round(time, 3));
        }
    }
}
