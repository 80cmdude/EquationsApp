using EquationApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EquationApp
{
    public partial class Template : ContentPage
    {
        public Template()
        {
            this.Title = "Paguco";
            InitializeComponent();

            //Add ui elements to remove on first load

            //calculateTo.SelectedIndexChanged += (sender, args) =>
            //{
            //    SetInputFields();
            //    <Set all the ui elements to empty here>
            //};
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
        //            Alerts.InvalidInput(messageToUser: "Please select a value to calculate");
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
        //        Alerts.InvalidInput(messageToUser: $"Must enter a valid number into the fields");
        //    }
        //    catch (DivideByZeroException j)
        //    {
        //        Alerts.InvalidInput(messageToUser: "Cannot divide by 0");
        //    }
        //    catch (Exception j)
        //    {
        //        Alerts.InvalidInput(messageToUser: j.Message);
        //    }
        //}
    }
}
