using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EquationApp
{
    public static class Alerts
    {
        /// <summary>
        /// Diplays an alert to the user that can be dismissed with a button
        /// </summary>
        /// <param name="title"></param>
        /// <param name="messageToUser"></param>
        /// <param name="dismissText"></param>
        public static void InvalidInput(string title = "Warning", string messageToUser = "Invalid Operation!", string dismissText = "OK")
        {
            ContentPage Content = new ContentPage();
            Content.DisplayAlert(title, messageToUser, dismissText);
        }
    }
}
