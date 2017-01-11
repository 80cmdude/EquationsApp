using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using EquationApp;
using EquationApp.Droid.Custom_Renderers;

[assembly: ExportRenderer(typeof(ButtonCase),typeof(ButtonCaseRenderer))]
namespace EquationApp.Droid.Custom_Renderers
{
    class ButtonCaseRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            var button = this.Control;
            button.SetAllCaps(false);
        }
    }
}