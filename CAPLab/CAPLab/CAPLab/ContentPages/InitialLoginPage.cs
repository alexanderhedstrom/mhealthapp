using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//This page is to contain the initial logic for validating a users login. 

namespace CAPLab
{
    class InitialLoginPage : ContentPage
    {
        Entry participantID, participantPass;
        Label loginStatusMessage;

        public InitialLoginPage()
        {
            NavigationPage.SetHasBackButton(this, false);
            this.loginStatusMessage = new Label { Text = string.Empty };
            var title = new Label
            {
                Text = "OSU CAPLab",
                HorizontalTextAlignment = TextAlignment.Center,
                Font = Font.BoldSystemFontOfSize(NamedSize.Large)
            };
            participantID = new Entry
            {
                Placeholder = "Enter your participant ID here",
            };

            participantPass = new Entry
            {
                Placeholder = "Enter your password here"
            };

            var loginButton = new Button
            {
                Text = "Login"
            };

            var logo = new Image { WidthRequest = 80, HeightRequest = 80 };
            logo.Source = ImageSource.FromFile("osuLoginIcon.png");

            loginButton.Clicked += OnLoginButtonClicked;

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children =
                {
                    title,
                    logo,
                    participantID,
                    participantPass,
                    loginButton,
                    loginStatusMessage
                }
            };
        }

        void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                ParticipantID = participantID.Text.ToLower(),
                Password = participantPass.Text
            };

            var userIsValid = areCredentialsCorrect(user);
            if (userIsValid)
            {
                App.loggedIn = true;
                //The line below creates a homepage behind the current one.
                Navigation.InsertPageBefore(new HomepageNav(), this);
                //The line below removes the current page to reveal the newly created homepage.
                Navigation.PopAsync();
            }
            else
            {
                loginStatusMessage.Text = "Login failed";
                participantPass.Text = string.Empty;
            }

        }

        protected override bool OnBackButtonPressed()
        {
            //the closers below use the dependency service to ensure that the application exits regardless of platform. 
            //Info in dependency service: https://developer.xamarin.com/guides/xamarin-forms/dependency-service/introduction/
            var closer = DependencyService.Get<ICloseApplication>();
            closer.CloseApp();

            return true;
        }

        bool areCredentialsCorrect(User user)
        {
            return user.ParticipantID == Constants.ParticipantID && user.Password == Constants.Password;
            /*This is where the call out to the server will go.
              the call from the server will return true or false based on if the participant exists and has correct credentials
              For now it just compares the creds in the Constants.cs class. 
             */
        }
    }
}
