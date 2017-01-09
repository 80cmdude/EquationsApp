using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Properties;

using Xamarin.Forms;

namespace EquationApp
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            this.Title = AppResources.uchuu;
        }

        void NavigateToPaguCo(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.uchuu.io/"));
        }
         void MailToFeedback(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:feedback@uchuu.io"));
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
