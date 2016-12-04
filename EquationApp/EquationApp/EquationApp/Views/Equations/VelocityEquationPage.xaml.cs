using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Controllers.Equations;
using EquationApp;

using Xamarin.Forms;

namespace EquationApp.Views.Equations
{
    public partial class VelocityEquationPage : ContentPage
    {
        public VelocityEquationPage()
        {
            InitializeComponent();
            timeEntry.IsVisible = false;
            distanceEntry.IsVisible = false;
            velocityEntry.IsVisible = false;

            calculateTo.SelectedIndexChanged += (sender, args) => { SetInputFields(); };
        }

        void SetInputFields()
        {
            timeEntry.IsVisible = false;
            distanceEntry.IsVisible = false;
            velocityEntry.IsVisible = false;
            if (calculateTo.SelectedIndex == 0)
            {
                velocityEntry.IsVisible = true;
                timeEntry.IsVisible = true;
            }
            else if (calculateTo.SelectedIndex == 1)
            {
                velocityEntry.IsVisible = true;
                distanceEntry.IsVisible = true;
            }
            else
            {
                distanceEntry.IsVisible = true;
                timeEntry.IsVisible = true;
            }
        }

        void Calculate(object sender, EventArgs e)
        {
            if (calculateTo.SelectedIndex == 0)
            {
                try
                {
                    string distance = VelocityEquation.GetDistance(velocityEntry.Text, timeEntry.Text);
                    Result.Text = distance;
                }
                catch (DivideByZeroException j)
                {
                    Alerts.InvalidInput(messageToUser: "Cannot divide by zero");
                }
                catch (Exception j)
                {
                    Alerts.InvalidInput(messageToUser: j.Message);
                }
            }
            else if (calculateTo.SelectedIndex == 1)
            {
                try
                {
                    string time = VelocityEquation.GetTime(velocityEntry.Text, distanceEntry.Text);
                    Result.Text = time;
                }
                catch (DivideByZeroException j)
                {
                    Alerts.InvalidInput(messageToUser: "Cannot divide by zero");
                }
                catch (Exception j)
                {
                    Alerts.InvalidInput(messageToUser: j.Message);
                }
            }
            else
            {
                try
                {
                    string velocity = VelocityEquation.GetVelocity(distanceEntry.Text, timeEntry.Text);
                    Result.Text = velocity;
                }
                catch (DivideByZeroException j)
                {
                    Alerts.InvalidInput(messageToUser: "Cannot divide by zero");
                }
                catch (Exception j)
                {
                    Alerts.InvalidInput(messageToUser: j.Message);
                }
            } 
        }
    }
}
