using EquationApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EquationApp
{
    public partial class TemplatePage : ContentPage
    {
        public TemplatePage()
        {
            this.Title = "Paguco";
            InitializeComponent();
            //.IsVisible = false;
            //.IsVisible = false;
            //.IsVisible = false;



            //calculateTo.SelectedIndexChanged += (sender, args) =>
            //{
            //    SetInputFields();
            //    Result.Text = "";
            //    .Text = "";
            //    .Text = "";
            //    .Text = "";
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
        //    .IsVisible = false;
        //    .IsVisible = false;
        //    .IsVisible = false;
        //    if (calculateTo.SelectedIndex == 0)
        //    {
        //        .IsVisible = true;
        //        .IsVisible = true;
        //        showHow.Text = "The distance travelled of and object is equal to the velocity of the object times the time it takes. \r\n d = v * t";
        //    }
        //    else if (calculateTo.SelectedIndex == 1)
        //    {
        //        .IsVisible = true;
        //        .IsVisible = true;
        //        showHow.Text = "The time taken for an object to travel a distance is equal to the distance travelled divide by the velocity. \r\n t = d / v";
        //    }
        //    else
        //    {
        //        .IsVisible = true;
        //        .IsVisible = true;
        //        showHow.Text = "The Velocity of and object is equal to the distance travelled divided by the time taken. \r\n v = d / t";
        //    }
        //}

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
