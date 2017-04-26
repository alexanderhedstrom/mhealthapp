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
using System.Threading.Tasks;
using Newtonsoft.Json;

[assembly: Dependency(typeof(APIConnector))]

namespace CAPLab.Droid
{
    class APIConnector : IAPIConnector
    {

        //TODO: Define URL's for uploading fitness data

        HttpClient client;
        
        //https://developer.xamarin.com/api/type/System.Net.Http.HttpClient/
        //https://developer.xamarin.com/guides/xamarin-forms/cloud-services/consuming/rest/
        //https://developer.xamarin.com/recipes/android/web_services/consuming_services/call_a_rest_web_service/
        //https://developer.xamarin.com/guides/cross-platform/application_fundamentals/web_services/#rest

        
        //this is a POST method
        public async Task<bool> RegisterUser(User user)
        {
            //The following are needed for registration: firstName, lastName, osuUsername, surveyCondition
            client = new HttpClient();

            var json = JsonConvert.SerializeObject(user);
            var post_content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage api_Response = null;

            api_Response = await client.PostAsync(Constants.URL_REGISTER, post_content);

            bool regStatus = api_Response.IsSuccessStatusCode;
            return regStatus;
            //TODO: set this method to be called after the initialSetupPage
        }

        //This is a POST method
        public async Task<User> VerifyLogin(User user)
        {
            client = new HttpClient();

            User api_SuppliedUser = new User();

            var data = JsonConvert.SerializeObject(user);
            var post_content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(Constants.URL_LOGIN, post_content);
            if (response.IsSuccessStatusCode)
            {
                var jsonReply = await response.Content.ReadAsStringAsync();
                api_SuppliedUser = JsonConvert.DeserializeObject<User>(jsonReply);
                App.loggedIn = true;
            }
            return api_SuppliedUser;
        }

        //This is a PUT method
        public async Task UpdateUser (User user)
        {
            //TODO: implement user update in app and on server. 
            //Will likely be done via the settings page
            client = new HttpClient();
        }
        //This is a PUT method
        public async Task UpdateStats (Stats stats)
        {
            //TODO: implement stats update in app and on server. 
            //Will be tied to a timed event on the primary app.
            client = new HttpClient();
        }
    }
}