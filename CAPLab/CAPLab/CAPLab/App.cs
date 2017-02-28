using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

/*
* File name: App.cs
* 
* @description This is the primary class around which the application is built and launched. 
*              This class serves as the entry point or beginning of the application. 
*              Application wireframe located at: http://jtyk30.axshare.com/#p=initial_setup
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 02/27/2017
* 
*/

namespace CAPLab
{
    public class App : Application
    {
        public static bool loggedIn = false;
        //public static User user;

        //need to write a way for the loggedIn bool to be able to read the login status from local storage
        public App()
        {
            //write code here to check local storage to verify if local data exists for the user on the device. 



            //////////////////////////////////////////////////////////////////////////////////////////////////

            //if no data is found then create a new user instance, create local data for user, pass new user object to the next class/page 



            //////////////////////////////////////////////////////////////////////////////////////////////////


            // if data is found then change App.loggedin to true then set variables from local data to user attributes then pass user object to the next class/page 



            //////////////////////////////////////////////////////////////////////////////////////////////////


            if (loggedIn)
            {
                MainPage = new NavigationPage(new HomepageNav())
                {
                    BarBackgroundColor = Color.Red
                };
            }
            else
            {
                MainPage = new NavigationPage(new InitialLoginPage())
                {
                    BarBackgroundColor = Color.Red
                };
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
