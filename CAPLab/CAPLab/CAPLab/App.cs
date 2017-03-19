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
        public static User user;
        public App()
        { 
            var localStorage = DependencyService.Get<ILocalStorageAccessor>();
            User user = localStorage.LoadUser();

            if (user.osuUsername != null && user.surveyCondition != null)
            {
                loggedIn = true;
            }


            if (loggedIn)
            {
                MainPage = new NavigationPage(new HomepageNav(user))
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

            // TODO: implement timer that syncs every 15 minutes if loggedIn == true
            //https://developer.xamarin.com/api/type/System.Threading.Timer/
            //https://developer.xamarin.com/api/type/System.Timers.Timer/
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
