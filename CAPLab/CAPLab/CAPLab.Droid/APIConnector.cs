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
        //TODO write code to consume JSON
        // https://developer.xamarin.com/guides/cross-platform/application_fundamentals/web_services/#rest

        HttpClient client;

        public APIConnector()
        {

        }
    }
}