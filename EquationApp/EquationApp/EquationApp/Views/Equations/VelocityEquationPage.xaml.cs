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
            velocityUI.IsVisible = false;
            distanceUI.IsVisible = false;
            timeUI.IsVisible = false;

            calculateTo.SelectedIndexChanged += (sender, args) => 
            {
                SetInputFields();
                Result.Text = "";
                timeEntry.Text = "";
                velocityEntry.Text = "";
                distanceEntry.Text = "";
            };
        }

        void SetInputFields()
        {
            velocityUI.IsVisible = false;
            distanceUI.IsVisible = false;
            timeUI.IsVisible = false;
            if (calculateTo.SelectedIndex == 0)
            {
                velocityUI.IsVisible = true;
                timeUI.IsVisible = true;
            }
            else if (calculateTo.SelectedIndex == 1)
            {
                velocityUI.IsVisible = true;
                distanceUI.IsVisible = true;
            }
            else
            {
                distanceUI.IsVisible = true;
                timeUI.IsVisible = true;
            }
        }

        void Calculate(object sender, EventArgs e)
        {
            try
            {
                if (calculateTo.SelectedIndex == -1)
                {
                    Alerts.InvalidInput(messageToUser: "Please select a value to calculate");
                }
                else
                {
                    if (calculateTo.SelectedIndex == 0)
                    {
                        string distance = VelocityEquation.GetDistance(velocityEntry.Text, timeEntry.Text);
                        Result.Text = distance;
                    }
                    else if (calculateTo.SelectedIndex == 1)
                    {
                        string time = VelocityEquation.GetTime(velocityEntry.Text, distanceEntry.Text);
                        Result.Text = time;
                    }
                    else
                    {
                        string velocity = VelocityEquation.GetVelocity(distanceEntry.Text, timeEntry.Text);
                        Result.Text = velocity;
                    }
                }
            }
            catch (FormatException j)
            {
                Alerts.InvalidInput(messageToUser: $"Must enter a valid number into the fields");
            }
            catch (DivideByZeroException j)
            {
                Alerts.InvalidInput(messageToUser: "Cannot divide by 0");
            }
            catch (Exception j)
            {
                Alerts.InvalidInput(messageToUser: j.Message);
            }
        }
    }
}
