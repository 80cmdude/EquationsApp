using System;
using EquationApp.Models;

namespace EquationApp.Controllers.Equations
{
    public static class VelocityEquation
    {
        public static Validation validateUserNumberInput(string a, string b)
        {
            Validation error = new Validation();

            if (a == null || b == null || a == "" || b == "" || a == "." || b == "." )
            {
                error.isValid = false;
                error.errorMessage = "Please Enter a number";
                return error;
            }
            else
            {
                decimal aResult = Convert.ToDecimal(a);
                decimal bResult = Convert.ToDecimal(b);

                if (aResult == 0 || bResult == 0)
                {
                    error.isValid = false;
                    error.errorMessage = "Distance and time must be above 0";
                    return error;
                }
                else
                {
                    error.isValid = true;
                    return error;
                }
            }
        }
        public static string GetVelocity(string userDistance, string userTime)
        {
            decimal distance = Convert.ToDecimal(userDistance);
            decimal time = Convert.ToDecimal(userTime);

            decimal velocity = distance / time;

            return velocity.ToString();
        }
    }
}
