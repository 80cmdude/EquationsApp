using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Views.Equations;

using Xamarin.Forms;
using EquationApp.Properties;

namespace EquationApp.Views.Pages
{
    public partial class ElectricityPage : ContentPage
    {
        public ElectricityPage()
        {
            this.Title = AppResources.uchuu;
            InitializeComponent();
        }

        async void NavigatePageRVI(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resistance_RVI_Page());
        }
    }
}
