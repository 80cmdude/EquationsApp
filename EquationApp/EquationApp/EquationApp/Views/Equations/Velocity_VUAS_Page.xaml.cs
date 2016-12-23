using EquationApp.Controllers;
using EquationApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EquationApp.Views.Equations
{
    public partial class Velocity_VUAS_Page : ContentPage
    {
        public Velocity_VUAS_Page()
        {
            this.Title = AppResources.paguco;
            InitializeComponent();

            finalVelocityUI.IsVisible = false;
            initialVelocityUI.IsVisible = false;
            accelerationUI.IsVisible = false;
            distanceUI.IsVisible = false;

            //Add ui elements to remove on first load

            calculateTo.SelectedIndexChanged += (sender, args) =>
            {
                SetInputFields();
                finalVelocityEntry.Text = "";
                initialVelocityEntry.Text = "";
                accelerationEntry.Text = "";
                distanceEntry.Text = "";

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
            distanceUI.IsVisible = false;
            if (calculateTo.SelectedIndex == 0)
            {
                initialVelocityUI.IsVisible = true;
                accelerationUI.IsVisible = true;
                distanceUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
            else if (calculateTo.SelectedIndex == 1)
            {
                finalVelocityUI.IsVisible = true;
                accelerationUI.IsVisible = true;
                distanceUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
            else if (calculateTo.SelectedIndex == 2)
            {
                initialVelocityUI.IsVisible = true;
                finalVelocityUI.IsVisible = true;
                distanceUI.IsVisible = true;
                //showHow.Text = "<Description of Equation>";
            }
            else
            {
                initialVelocityUI.IsVisible = true;
                finalVelocityUI.IsVisible = true;
                accelerationUI.IsVisible = true;
            }
        }

        //void Calculate(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (calculateTo.SelectedIndex == -1)
        //        {
        //            Alerts.InvalidInput(messageToUser: AppResources.emtpyEquationPickerCalculate);
        //        }
        //        else
        //        {
        //            if (calculateTo.SelectedIndex == 0)
        //            {
        //                //Proccess the work here
        //                //showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";
        //            }
        //            else if (calculateTo.SelectedIndex == 1)
        //            {
        //                //Proccess the work here
        //                //showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";      }
        //            }
        //            else
        //            {
        //                //Proccess the work here
        //                //showHow.Text = $"The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n {Result.Text} = {velocityEntry.Text} * {timeEntry.Text}";  }
        //            }
        //        }
        //    catch (FormatException j)
        //    {
        //        Alerts.InvalidInput(messageToUser: AppResources.errorFormatMessage);
        //    }
        //    catch (DivideByZeroException j)
        //    {
        //        Alerts.InvalidInput(messageToUser: AppResources.errorDivideByZeroMessage);
        //    }
        //    catch (Exception j)
        //    {
        //        Alerts.InvalidInput(messageToUser: j.Message);
        //    }
        //}
    }
}
