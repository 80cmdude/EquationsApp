using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Controllers.Equations;
using EquationApp.Models;
using EquationApp;

using Xamarin.Forms;

namespace EquationApp.Views.Equations
{
    public partial class VelocityEquationPage : ContentPage
    {
        public VelocityEquationPage()
        {
            InitializeComponent();
        }

        void CalculateVelocity(object sender, EventArgs e)
        {
            try
            {
                string velocity = VelocityEquation.GetVelocity(distanceEntry.Text, timeEntry.Text);
                velocityResult.Text = velocity;
            }
            catch (DivideByZeroException j)
            {
                Alerts.InvalidInput(messageToUser: "Cannot divide by zero");
            }
            catch (Exception j)
            {
                Alerts.InvalidInput(messageToUser: "Something went wrong");
            }
            //Validation isValid = VelocityEquation.validateUserNumberInput(distanceEntry.Text, timeEntry.Text);
            //if (isValid.isValid == true)
            //{
            //    string velocity = VelocityEquation.GetVelocity(distanceEntry.Text, timeEntry.Text);
            //    velocityResult.Text = velocity;
            //}
            //else
            //{
            //    Alerts.InvalidInput(messageToUser: isValid.errorMessage);
            //}
        }
    }
}
