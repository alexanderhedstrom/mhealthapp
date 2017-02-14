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
            Icon = "survey.png";
            var buttonLayout = new StackLayout();

            //More buttons will need to be created or a single button that has the link behind it change based on other factors
            var surveyLinkButton1 = new Button
            {
                Text = "Survey 1",
                BackgroundColor = Color.Red
            };

            var surveyLinkButton2 = new Button
            {
                Text = "Survey 2"
            };

            var surveyLinkButton3 = new Button
            {
                Text = "Survey 3"
            };

            var surveyLinkButton4 = new Button
            {
                Text = "Survey 4"
            };

            var placeholderText = new Label
            {
                Text = "This page is to contain links to external or internal content for survey taking"
            };

            surveyLinkButton1.Clicked += SurveyLaunch;
            surveyLinkButton2.Clicked += SurveyLaunch;
            surveyLinkButton3.Clicked += SurveyLaunch;
            surveyLinkButton4.Clicked += SurveyLaunch;
            buttonLayout.Children.Add(placeholderText);
            buttonLayout.Children.Add(surveyLinkButton1);
            buttonLayout.Children.Add(surveyLinkButton2);
            buttonLayout.Children.Add(surveyLinkButton3);
            buttonLayout.Children.Add(surveyLinkButton4);


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
