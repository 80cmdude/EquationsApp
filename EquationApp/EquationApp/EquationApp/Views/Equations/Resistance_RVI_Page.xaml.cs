using EquationApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Controllers.Equations;

using Xamarin.Forms;
using EquationApp.Properties;

namespace EquationApp.Views.Equations
{
    public partial class Resistance_RVI_Page : ContentPage
    {
        public Resistance_RVI_Page()
        {
            this.Title = AppResources.paguco;
            InitializeComponent();
            voltageUI.IsVisible = false;
            resistanceUI.IsVisible = false;
            currentUI.IsVisible = false;

            calculateTo.SelectedIndexChanged += (sender, args) =>
            {
                SetInputFields();
                Result.Text = "";
                voltageEntry.Text = "";
                currentEntry.Text = "";
                resistanceEntry.Text = "";
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
            voltageUI.IsVisible = false;
            resistanceUI.IsVisible = false;
            currentUI.IsVisible = false;
            if (calculateTo.SelectedIndex == 0)
            {
                voltageUI.IsVisible = true;
                currentUI.IsVisible = true;
                showHow.Text = string.Format(AppResources.resistance_RVI_resistanceAnswer, "R", "V", "I");
            }
            else if (calculateTo.SelectedIndex == 1)
            {
                currentUI.IsVisible = true;
                resistanceUI.IsVisible = true;
                showHow.Text = string.Format(AppResources.resistance_RVI_voltageAnswer, "V", "I", "R");
            }
            else
            {
                voltageUI.IsVisible = true;
                resistanceUI.IsVisible = true;
                showHow.Text = string.Format(AppResources.resistance_RVI_currentAnswer, "I", "V", "R");
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
                        string resistance = Resistance_RVI.GetResistance(voltageEntry.Text, currentEntry.Text);
                        Result.Text = resistance;
                        showHow.Text = string.Format(AppResources.resistance_RVI_resistanceAnswer, resistance, voltageEntry.Text, currentEntry.Text);
                    }
                    else if (calculateTo.SelectedIndex == 1)
                    {
                        string voltage = Resistance_RVI.GetVoltage(resistanceEntry.Text, currentEntry.Text);
                        Result.Text = voltage;
                        showHow.Text = string.Format(AppResources.resistance_RVI_voltageAnswer, voltage, currentEntry.Text, resistanceEntry.Text);
                    }
                    else
                    {
                        string current = Resistance_RVI.GetCurrent(voltageEntry.Text, resistanceEntry.Text);
                        Result.Text = current;
                        showHow.Text = string.Format(AppResources.resistance_RVI_currentAnswer, current, voltageEntry.Text, resistanceEntry.Text);
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
