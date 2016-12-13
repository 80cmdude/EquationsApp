using EquationApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Controllers.Equations;

using Xamarin.Forms;

namespace EquationApp.Views.Equations
{
    public partial class Distance_SUAT_Page : ContentPage
    {
        public Distance_SUAT_Page()
        {
            this.Title = "Paguco";
            InitializeComponent();

            distanceUI.IsVisible = false;
            initialVelocityUI.IsVisible = false;
            timeUI.IsVisible = false;
            accelerationUI.IsVisible = false;

            calculateTo.SelectedIndexChanged += (sender, args) =>
            {
                SetInputFields();
                distanceEntry.Text = "";
                initialVelocityEntry.Text = "";
                timeEntry.Text = "";
                accelerationEntry.Text = "";
            };
        }
        void ChangeMode(object sender, EventArgs e)
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
            distanceUI.IsVisible = false;
            initialVelocityUI.IsVisible = false;
            timeUI.IsVisible = false;
            accelerationUI.IsVisible = false;
            if (calculateTo.SelectedIndex == 0)
            {
                initialVelocityUI.IsVisible = true;
                timeUI.IsVisible = true;
                accelerationUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
            else if (calculateTo.SelectedIndex == 1)
            {
                distanceUI.IsVisible = true;
                timeUI.IsVisible = true;
                accelerationUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
            else if (calculateTo.SelectedIndex == 2)
            {
                initialVelocityUI.IsVisible = true;
                timeUI.IsVisible = true;
                distanceUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
            else
            {
                initialVelocityUI.IsVisible = true;
                distanceUI.IsVisible = true;
                accelerationUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
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
                        string distance = Distance_SUAT.GetDistance(initialVelocityEntry.Text, accelerationEntry.Text, timeEntry.Text);
                        Result.Text = distance;
                        //showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";
                    }
                    else if (calculateTo.SelectedIndex == 1)
                    {
                        string initialVelocity = Distance_SUAT.GetInitialVelocity(distanceEntry.Text, accelerationEntry.Text, timeEntry.Text);
                        Result.Text = initialVelocity;
                        //showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";      }
                    }
                    else if (calculateTo.SelectedIndex == 2)
                    {
                        string acceleration = Distance_SUAT.GetAcceleration(distanceEntry.Text, timeEntry.Text, initialVelocityEntry.Text);
                        Result.Text = acceleration;
                        //showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";  }
                    }
                    else
                    {
                        string time = Distance_SUAT.GetTime(distanceEntry.Text, initialVelocityEntry.Text, accelerationEntry.Text);
                        Result.Text = time;
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
