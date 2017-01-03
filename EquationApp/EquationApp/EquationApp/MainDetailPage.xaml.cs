using EquationApp.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Properties;

using Xamarin.Forms;

namespace EquationApp
{
    public partial class MainDetailPage : ContentPage
    {
        public MainDetailPage()
        {
            InitializeComponent();
            this.Title = AppResources.uchuu;
        }

        async void NavigatePageElectricity(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ElectricityPage());
        }

        async void NavigatePageMechanics(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MechanicsPage());
        }
    }
}
