using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp.Views.Equations;
using EquationApp.Views.Pages;
using EquationApp.Properties;

using Xamarin.Forms;

namespace EquationApp
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MainDetailPage());
            this.Title = AppResources.uchuu;
        }

        void NavigateHomePage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainDetailPage());
            this.IsPresented = false;
        }

        void NavigatePageAbout(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutPage());
            this.IsPresented = false;
        }
    }
}
