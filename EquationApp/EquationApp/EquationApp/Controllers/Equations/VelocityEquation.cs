using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp.Controllers.Equations
{
    public static class VelocityEquation
    {
        public static string GetVelocity(string userDistance, string userTime)
        {
            int distance = Convert.ToInt32(userDistance);
            int time = Convert.ToInt32(userTime);

            int velocity = distance / time;

            return velocity.ToString();
        }
    }
}
