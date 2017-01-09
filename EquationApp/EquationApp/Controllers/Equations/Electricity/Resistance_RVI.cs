using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp;

namespace EquationApp.Controllers.Equations
{
    
    public static class Resistance_RVI
    {
        public static string GetResistance(string userVoltage, string userCurrent)
        {
            decimal resistance = Utils.Divide(userVoltage, userCurrent);
            return $"{Math.Round(resistance, 3).ToString()} Ohms";
        }

        public static string GetVoltage(string userResistance, string userCurrent)
        {
            decimal voltage = Utils.Multiply(userResistance, userCurrent);

            return $"{Math.Round(voltage, 3).ToString()} V";
        }

        public static string GetCurrent(string userVoltage, string userResistance)
        {
            decimal current = Utils.Divide(userVoltage, userResistance);

            return $"{Math.Abs(Math.Round(current, 3)).ToString()} A";
        }
    }
}
