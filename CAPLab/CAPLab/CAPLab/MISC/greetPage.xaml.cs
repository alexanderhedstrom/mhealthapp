using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CAPLab
{
    public partial class greetPage : ContentPage
    {
        public greetPage()
        {
            var layout = new StackLayout();
            var helloWorldButton = new Button
            {
                Text = "Click me!"
            };

            helloWorldButton.Clicked += Handle_Clicked;

            layout.Children.Add(helloWorldButton);

            Content = layout;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("CAPLab app", "Hello World", "Done.");
        }
    }
}
