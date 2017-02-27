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
        public string surveyLink = "https://osu.az1.qualtrics.com/SE/?SID=SV_eX5ppb0p9OkpjlH";
        public string surveyLinkButton1Text = "Exercise survey";
        public string surveyLinkButton2Text = "Eating survey";
        public string surveyLinkButton3Text = "Attitudes survey";
        public string surveyLinkButton4Text = "Other survey";

        public SurveyPage()
        {
            Icon = "survey.png";
            var buttonLayout = new StackLayout();

            //More buttons will need to be created or a single button that has the link behind it change based on other factors
            var surveyLinkButton1 = new Button
            {
                Text = surveyLinkButton1Text,
                BackgroundColor = Color.Gray
            };

            var surveyLinkButton2 = new Button
            {
                Text = surveyLinkButton2Text,
                BackgroundColor = Color.Gray
            };

            var surveyLinkButton3 = new Button
            {
                Text = surveyLinkButton3Text,
                BackgroundColor = Color.Gray
            };

            var surveyLinkButton4 = new Button
            {
                Text = surveyLinkButton4Text,
                BackgroundColor = Color.Gray
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
            //changinf where the button points to is as simple as updating the public surveyLink variable via another method
            //currrently all buttons point to this URL. This method will need to be duplicated if there will be several surveys simultaneously.
            Device.OpenUri(new Uri (surveyLink));
            //link to test survey; https://osu.az1.qualtrics.com/SE/?SID=SV_eX5ppb0p9OkpjlH
        }
    }
}
