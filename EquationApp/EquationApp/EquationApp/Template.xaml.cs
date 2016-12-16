using EquationApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Properties;

using Xamarin.Forms;

namespace EquationApp
{
    public partial class Template : ContentPage
    {
        public Template()
        {
            this.Title = AppResources.paguco;
            InitializeComponent();

            //Add ui elements to remove on first load

            //calculateTo.SelectedIndexChanged += (sender, args) =>
            //{
            //    SetInputFields();
            //    <Set all the ui entrys to empty here>
            //};
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

        //void SetInputFields()
        //{
        //    //Ui elements to false here
        //    if (calculateTo.SelectedIndex == 0)
        //    {
        //        //Ui to true here
        //        //showHow.Text = "<Description of Equation>";
        //    }
        //    else if (calculateTo.SelectedIndex == 1)
        //    {
        //        //Ui to true here
        //        //showHow.Text = "<Description of Equation>";
        //    }
        //    else
        //    {
        //        //Ui to true here
        //        //showHow.Text = "<Description of Equation>";
        //    }
        //}

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
