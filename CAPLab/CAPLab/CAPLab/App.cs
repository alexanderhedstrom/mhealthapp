using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CAPLab
{
    public class App : Application
    {
        public static bool loggedIn = true;
        public App()
        {
            // The root page of your application
            /*var content = new ContentPage
            {
                Title = "CAPLab",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Hello World!"
                        }
                    }
                }
            };*/

            if (loggedIn)
            {
                MainPage = new NavigationPage(new InitialLoginPage());
            }else
            {
                MainPage = new NavigationPage(new Homepage());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
