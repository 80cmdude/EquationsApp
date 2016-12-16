using EquationApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Controllers.Equations;
using EquationApp.Properties;

using Xamarin.Forms;

namespace EquationApp.Views.Equations
{
    public partial class Velocity_VUAT_Page : ContentPage
    {
        public Velocity_VUAT_Page()
        {
            this.Title = AppResources.paguco;
            InitializeComponent();

            finalVelocityUI.IsVisible = false;
            initialVelocityUI.IsVisible = false;
            accelerationUI.IsVisible = false;
            timeUI.IsVisible = false;

            calculateTo.SelectedIndexChanged += (sender, args) =>
            {
                SetInputFields();
                finalVelocityEntry.Text = "";
                initialVelocityEntry.Text = "";
                accelerationEntry.Text = "";
                timeEntry.Text = "";
            };
        }
        void ChangeMode(object sender, EventArgs e)
        {
            ModeChange.ChangeMode();
            if (GlobalVar.showHow == true)
            {
                learnerMode.IsVisible = false;
                modeChangerButton.Text = AppResources.btnShowMeHow;
            }
            else
            {
                learnerMode.IsVisible = true;
                modeChangerButton.Text = AppResources.btnHideHow;
            }
        }

        void SetInputFields()
        {
            finalVelocityUI.IsVisible = false;
            initialVelocityUI.IsVisible = false;
            accelerationUI.IsVisible = false;
            timeUI.IsVisible = false;

            if (calculateTo.SelectedIndex == 0)
            {
                initialVelocityUI.IsVisible = true;
                accelerationUI.IsVisible = true;
                timeUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
            else if (calculateTo.SelectedIndex == 1)
            {
                finalVelocityUI.IsVisible = true;
                accelerationUI.IsVisible = true;
                timeUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
            else if (calculateTo.SelectedIndex == 2)
            {
                finalVelocityUI.IsVisible = true;
                initialVelocityUI.IsVisible = true;
                timeUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
            else
            {
                finalVelocityUI.IsVisible = true;
                initialVelocityUI.IsVisible = true;
                timeUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
        }

        void Calculate(object sender, EventArgs e)
        {
            try
            {
                if (calculateTo.SelectedIndex == -1)
                {
                    Alerts.InvalidInput(messageToUser: AppResources.emtpyEquationPickerCalculate);
                }
                else
                {
                    if (calculateTo.SelectedIndex == 0)
                    {
                        Result.Text = Velocity_VUAT.getFinalVelocity(initialVelocityEntry.Text,accelerationEntry.Text,timeEntry.Text);
                        //showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";
                    }
                    else if (calculateTo.SelectedIndex == 1)
                    {
                        Result.Text = Velocity_VUAT.getInitialVelocity(finalVelocityEntry.Text, accelerationEntry.Text, timeEntry.Text);
                        //showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";      }
                    }
                    else if (calculateTo.SelectedIndex == 2)
                    {
                        Result.Text = Velocity_VUAT.getAcceleration(finalVelocityEntry.Text, initialVelocityEntry.Text, timeEntry.Text);
                        //showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";  }
                    }
                    else
                    {
                        Result.Text = Velocity_VUAT.getTime(finalVelocityEntry.Text, initialVelocityEntry.Text, accelerationEntry.Text);
                    }
                }
            }
            catch (FormatException j)
            {
                Alerts.InvalidInput(messageToUser: AppResources.errorFormatMessage);
            }
            catch (DivideByZeroException j)
            {
                Alerts.InvalidInput(messageToUser: AppResources.errorDivideByZeroMessage);
            }
            catch (Exception j)
            {
                Alerts.InvalidInput(messageToUser: j.Message);
            }
        }
    }
}
