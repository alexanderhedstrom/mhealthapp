using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

//Application wireframe located at: http://jtyk30.axshare.com/#p=initial_setup

namespace CAPLab
{
    public class App : Application
    {
        public static bool loggedIn = false;
        //need to write a way for the loggedIn bool to be able to read the login status from local storage
        public App()
        {


            if (loggedIn)
            {
                MainPage = new NavigationPage(new HomepageNav());
            }
            else
            {
                MainPage = new NavigationPage(new InitialLoginPage());
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
