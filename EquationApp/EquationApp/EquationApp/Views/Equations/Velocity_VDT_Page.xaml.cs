using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Controllers.Equations;
using EquationApp;
using EquationApp.Controllers;
using EquationApp.Properties;

using Xamarin.Forms;

namespace EquationApp.Views.Equations
{
    public partial class VelocityEquationPage : ContentPage
    {
        public VelocityEquationPage()
        {
            this.Title = AppResources.paguco;
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
            velocityUI.IsVisible = false;
            distanceUI.IsVisible = false;
            timeUI.IsVisible = false;
            if (calculateTo.SelectedIndex == 0)
            {
                velocityUI.IsVisible = true;
                timeUI.IsVisible = true;
                showHow.Text = string.Format(AppResources.velocity_VDT_distanceAnswer, "d", "v", "t");
            }
            else if (calculateTo.SelectedIndex == 1)
            {
                velocityUI.IsVisible = true;
                distanceUI.IsVisible = true;
                showHow.Text = string.Format(AppResources.velocity_VDT_timeAnswer, "t", "d", "v");
            }
            else
            {
                distanceUI.IsVisible = true;
                timeUI.IsVisible = true;
                showHow.Text = string.Format(AppResources.velocity_VDT_velocityAnswer, "v", "d", "t");
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
                        decimal distance = Velocity_VDT.GetDistance(velocityEntry.Text, timeEntry.Text);
                        Result.Text = string.Format(AppResources.lblResultDistance, distance);
                        showHow.Text = string.Format(AppResources.velocity_VDT_distanceAnswer, distance, velocityEntry.Text, timeEntry.Text);
                    }
                    else if (calculateTo.SelectedIndex == 1)
                    {
                        decimal time = Velocity_VDT.GetTime(velocityEntry.Text, distanceEntry.Text);
                        Result.Text = string.Format(AppResources.lblResultTime, time);
                        showHow.Text = string.Format(AppResources.velocity_VDT_timeAnswer, time, distanceEntry.Text, velocityEntry.Text);
                    }
                    else
                    {
                        decimal velocity = Velocity_VDT.GetVelocity(distanceEntry.Text, timeEntry.Text);
                        Result.Text = string.Format(AppResources.lblResultVelocity, velocity);
                        showHow.Text = string.Format(AppResources.velocity_VDT_velocityAnswer, velocity, distanceEntry.Text, timeEntry.Text);
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
