using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CAPLab
{
    // I intend to switch this to a TabbedPage once I figure out the syntax
    // Each page will have to made a child of the primary tabbed navigation page. 
    class Homepage : ContentPage
    {
        public Homepage()
        {
            //Consider implementing a logout function in the settings

            Title = "Homepage";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "This is the primary homepage",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
