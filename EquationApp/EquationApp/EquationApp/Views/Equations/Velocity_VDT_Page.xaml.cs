using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Controllers.Equations;
using EquationApp;
using EquationApp.Controllers;

using Xamarin.Forms;

namespace EquationApp.Views.Equations
{
    public partial class VelocityEquationPage : ContentPage
    {
        public VelocityEquationPage()
        {
            this.Title = "Paguco";
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
        
        void ChangeMode(object sender,EventArgs e)
        {
            ModeChange.ChangeMode();
            if (GlobalVar.showHow == true)
            {
                learnerMode.IsVisible = false;
                modeChangerButton.Text = "Show me how";
            }
            else
            {
                learnerMode.IsVisible = true;
                modeChangerButton.Text = "Hide how";
            }
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
                showHow.Text = "The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n d = v * t";
            }
            else if (calculateTo.SelectedIndex == 1)
            {
                velocityUI.IsVisible = true;
                distanceUI.IsVisible = true;
                showHow.Text = "The time taken for an object to travel a distance is equal to the distance travelled divide by the velocity. \r\n t = d / v";
            }
            else
            {
                distanceUI.IsVisible = true;
                timeUI.IsVisible = true;
                showHow.Text = "The Velocity of and object is equal to the distance travelled divided by the time taken. \r\n v = d / t";
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
                        showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";
                    }
                    else if (calculateTo.SelectedIndex == 1)
                    {
                        string time = VelocityEquation.GetTime(velocityEntry.Text, distanceEntry.Text);
                        Result.Text = time;
                        showHow.Text = $"The time taken for an object to travel a distance is equal to the distance travelled divide by the velocity. \r\n {Result.Text} = {distanceEntry.Text} / {velocityEntry.Text}";
                    }
                    else
                    {
                        string velocity = VelocityEquation.GetVelocity(distanceEntry.Text, timeEntry.Text);
                        Result.Text = velocity;
                        showHow.Text = $"The Velocity of an object is equal to the distance travelled divided by the time taken. \r\n {Result.Text} = {distanceEntry.Text} m / {timeEntry.Text} s";
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
