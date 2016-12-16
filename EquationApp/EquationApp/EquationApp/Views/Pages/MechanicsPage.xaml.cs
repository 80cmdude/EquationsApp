using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Views.Equations;

using Xamarin.Forms;

namespace EquationApp.Views.Pages
{
    public partial class MechanicsPage : ContentPage
    {
        public MechanicsPage()
        {
            this.Title = "Paguco";
            InitializeComponent();
        }

        async void NavigatePageVDT(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VelocityEquationPage());
        }

        async void NavigatePageSUAT(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Distance_SUAT_Page());
        }

        async void NavigatePageVUAT(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Velocity_VUAT_Page());
        }
    }
}
