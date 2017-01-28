using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CAPLab
{
    class InitialLoginPage : ContentPage
    {

        Entry participantID, participantPass;
        Label loginStatusMessage;

        public InitialLoginPage()
        {
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

            loginButton.Clicked += OnLoginButtonClicked;
            
            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children =
                {
                    title,
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
                ParticipantID = participantID.Text,
                Password = participantPass.Text
            };

            var userIsValid = areCredentialsCorrect(user);
            if (userIsValid)
            {
                App.loggedIn = true;
                //The line below creates a homepage behind the current one.
                Navigation.InsertPageBefore(new Homepage(), this);
                //The line below removes the current page to reveal the newly created homepage.
                Navigation.PopAsync();
            }
            else
            {
                loginStatusMessage.Text = "Login failed";
                participantPass.Text = string.Empty;
            }

        }

        bool areCredentialsCorrect (User user)
        {
            return user.ParticipantID == Constants.ParticipantID && user.Password == Constants.Password;
            /*This is where the call out to the server will go.
              the call from the server will return true or false based on if the participant exists and has correct credentials
              For now it just compares the creds in the Constants.cs class. 
             */
        }
    }
}
