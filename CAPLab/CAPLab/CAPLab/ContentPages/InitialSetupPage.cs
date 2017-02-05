using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CAPLab
{
    public class InitialSetupPage : ContentPage
    {
        public InitialSetupPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Initial setup page here" }
                }
            };
        }
    }
}
