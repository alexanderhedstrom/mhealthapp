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
    class Homepage : TabbedPage
    {
        public Homepage()
        {
            //Consider implementing a logout function in the settings


            //Move settings page to a button on the toolbar. 
            /*var toolbar = new ToolbarItem(
                new Button {
                Text = "Settings"

            });

            toolbar.Activated += ;*/

            Children.Add(new ContentPage
            {
                Title = "Homepage"
            });

            Children.Add(new ContentPage
            {
                Title = "Exercise"
            });

            Children.Add(new ContentPage
            {
                Title = "Eating"
            });

            Children.Add(new ContentPage
            {
                Title = "Survey"
            });


            /*Content = new StackLayout
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
            };*/
        }


    }
}
