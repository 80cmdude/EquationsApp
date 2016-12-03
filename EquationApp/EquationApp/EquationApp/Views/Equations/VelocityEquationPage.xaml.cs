using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Controllers.Equations;

using Xamarin.Forms;

namespace EquationApp.Views.Equations
{
    public partial class VelocityEquationPage : ContentPage
    {
        public VelocityEquationPage()
        {
            InitializeComponent();
        }

        void CalculateVelocity(object sender, EventArgs e)
        {
            string velocity = VelocityEquation.GetVelocity(distanceEntry.Text, timeEntry.Text);
            velocityResult.Text = velocity;
        }
    }
}
