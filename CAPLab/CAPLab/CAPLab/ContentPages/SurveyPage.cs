using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//This page is to contain links to external or internal content for survey taking

namespace CAPLab
{
    class SurveyPage : ContentPage
    {
        public SurveyPage()
        {

            var buttonLayout = new StackLayout();

            //More buttons will need to be created or a single button that has the link behind it change based on other factors
            var surveyLinkButton = new Button
            {
                Text = "Survey 1"
            };

            var placeholderText = new Label
            {
                Text = "This page is to contain links to external or internal content for survey taking"
            };

            surveyLinkButton.Clicked += SurveyLaunch;

            buttonLayout.Children.Add(surveyLinkButton);


            Content = buttonLayout;
        }

        void SurveyLaunch(Object sender, EventArgs e)
        {
            //Insert code here that determines what should happen when the survey 1 button is pressed. 

            //I will likely implement webview in this method
            //https://developer.xamarin.com/guides/xamarin-forms/user-interface/webview/ 
        }
    }
}
