using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EquationApp
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            this.Title = "Paguco";
        }

        void NavigateToPaguCo(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.pagu.co/"));
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
