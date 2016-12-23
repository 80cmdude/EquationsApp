using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp.Controllers.Equations
{
    public static class Velocity_VUAT
    {
        /// <summary>
        /// v = u + (at)
        /// </summary>
        /// <param name="initialVelocity"></param>
        /// <param name="acceleration"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static decimal getFinalVelocity(string initialVelocity, string acceleration, string time)
        {
            decimal u = Convert.ToDecimal(initialVelocity);
            decimal a = Convert.ToDecimal(acceleration);
            decimal t =  Convert.ToDecimal(time);

            decimal finalVelocity = u + (a * t);

            return Math.Round(finalVelocity, 3);
        }

        /// <summary>
        /// u = v - (at)
        /// </summary>
        /// <param name="finalVelocity"></param>
        /// <param name="acceleration"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static decimal getInitialVelocity(string finalVelocity, string acceleration, string time)
        {
            decimal v = Convert.ToDecimal(finalVelocity);
            decimal a = Convert.ToDecimal(acceleration);
            decimal t = Convert.ToDecimal(time);

            decimal initialVelocity = v - (a * t);

            return Math.Round(initialVelocity, 3);
        }

        /// <summary>
        /// a = (v - u) / t
        /// </summary>
        /// <param name="finalVelocity"></param>
        /// <param name="initialVelocity"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static decimal getAcceleration(string finalVelocity, string initialVelocity, string time)
        {
            decimal v = Convert.ToDecimal(finalVelocity);
            decimal u = Convert.ToDecimal(initialVelocity);
            decimal t = Convert.ToDecimal(time);

            decimal acceleration = (v - u) / t;

            return Math.Round(acceleration, 3);
        }

        /// <summary>
        /// t = (v - u) / a
        /// </summary>
        /// <param name="finalVelocity"></param>
        /// <param name="intialVelocity"></param>
        /// <param name="acceleration"></param>
        /// <returns></returns>
        public static decimal getTime(string finalVelocity, string intialVelocity, string acceleration)
        {
            decimal v = Convert.ToDecimal(finalVelocity);
            decimal u = Convert.ToDecimal(intialVelocity);
            decimal a = Convert.ToDecimal(acceleration);

            decimal time = (v - u) / a;

            return Math.Round(time, 3);
        }
    }
}
