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
using Xamarin.Forms;
using CAPLab;
using CAPLab.Droid;
using System.Net.Http;

[assembly: Dependency(typeof(APIConnector))]

namespace CAPLab.Droid
{
    class APIConnector : IAPIConnector
    {
        //Server user login URL
        public static string URL_Login = "https://mhealth.asc.ohio-state.edu/mhealth_api/login.php";
        //Server user register URL
        public static string URL_Register = "https://mhealth.asc.ohio-state.edu/mhealth_api/register.php";

        //TODO: Define URL's for uploading fitness data


        //TODO write code to consume JSON
        // https://developer.xamarin.com/guides/cross-platform/application_fundamentals/web_services/#rest

        //TODO: implement the SQL DB connection

        HttpClient client;
        
        //https://developer.xamarin.com/api/type/System.Net.Http.HttpClient/
        //https://developer.xamarin.com/guides/xamarin-forms/cloud-services/consuming/rest/
        //https://developer.xamarin.com/recipes/android/web_services/consuming_services/call_a_rest_web_service/
        //https://developer.xamarin.com/guides/cross-platform/application_fundamentals/web_services/#rest
        public APIConnector()
        {
            
        }
        
        public void registerUser(string firstName, string lastName, string osuUsername, string surveyCondition)
        {
            //TODO: implement the POST login 

            //TODO: set this method to be called after the initialSetupPage
        }

        public void verifyLogin(string osuUsername, string surveyCondition)
        {
            //TODO: implement the comparison of login credentials
        }
    }
}