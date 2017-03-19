using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using CAPLab;
using CAPLab.iOS;
using System.Net.Http;
[assembly: Dependency(typeof(APIConnector))]

namespace CAPLab.iOS
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
