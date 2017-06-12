using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Auth;
using Xamarin.Forms;

/*
* File name: InitialSetupPage.cs
* 
* @description This class exists to render and control the logic of the initial login page of the primary app. 
*              This page is to contain the first time setup and logic for generation of a User class. 
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 04/20/2017
* 
*/

namespace CAPLab
{
    public class InitialSetupPage : ContentPage
    {
        Button dietGoalsButton;
        Button exerciseGoalsButton;
        Button doneButton;
        User user;


        public InitialSetupPage(User user)
        {
            this.user = user;
            Label userLabel = new Label { Text =  "Hi "+user.FirstName+", Your OSU ID is: "+user.OsuUsername};
            Label instructionText1 = new Label { Text = "Connect your accounts by selecting each one below: "};
            Label instructionText2 = new Label { Text = "Set your goals!" };

            var fitBitButton = new Button
            {
                Text = "FitBit",
                BackgroundColor = Color.Gray
            };
            fitBitButton.Clicked += OnFitBitButtonClicked;

            var myFitnessPalButton = new Button
            {
                Text = "MyFitnessPal",
                BackgroundColor = Color.Gray
            };
            myFitnessPalButton.Clicked += OnMyFitnessPalButtonClicked;

            var otherAppButton = new Button
            {
                Text = "Other",
                BackgroundColor = Color.Gray
            };

            dietGoalsButton = new Button
            {
                Text = "Diet Goals",
                BackgroundColor = Color.Gray
            };
            dietGoalsButton.Clicked += DietGoalsButtonClicked;

            exerciseGoalsButton = new Button
            {
                Text = "Exercise Goals",
                BackgroundColor = Color.Gray
            };
            exerciseGoalsButton.Clicked += ExerciseGoalsButtonClicked;

            doneButton = new Button
            {
                Text = "Done?",
                BackgroundColor = Color.Red
            };
            doneButton.Clicked += DoneButtonClicked;

            Content = new StackLayout
            {
                Children = {
                    userLabel,
                    instructionText1,
                    fitBitButton,
                    myFitnessPalButton,
                    otherAppButton,
                    instructionText2,
                    dietGoalsButton,
                    exerciseGoalsButton,
                    doneButton
                }
            };
        }

        private void OnMyFitnessPalButtonClicked(object sender, EventArgs e)
        {
            //private API requiring approval. Will implement later.

        }

        private void OnFitBitButtonClicked(object sender, EventArgs e)
        {
            OAuth2Authenticator fitbitAuth = new OAuth2Authenticator(
                   clientId: "",
                   clientSecret: "",
                   scope: "",
                   accessTokenUrl: new Uri("https://api.fitbit.com/oauth2/token"),
                   authorizeUrl: new Uri("https://www.fitbit.com/oauth2/authorize?response_type=token&client_id=2289T2&redirect_uri=https%3A%2F%2Fmhealth.asc.ohio-state.edu%2F&scope=activity%20heartrate%20location%20nutrition%20profile%20settings%20sleep%20social%20weight&expires_in=604800"),
                   redirectUrl: new Uri("https://mhealth.asc.ohio-state.edu/")
                   );
            fitbitAuth.Completed += (authSender, eventArgs) =>
            {

                if (eventArgs.IsAuthenticated)
                {
                    // Use eventArgs.Account to do wonderful things

                }
                else
                {
                    // The user cancelled
                }
            };
        }


        // launches diet goals page
        void DietGoalsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DietGoalsPage());
        }
        //launches exercise goals page
        void ExerciseGoalsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExerciseGoalsPage());
        }

        //Launches the homepage, passes the user object and removes the current page from view
        void DoneButtonClicked(object sender, EventArgs e)
        {
            var localStorage = DependencyService.Get<ILocalStorageAccessor>();
            localStorage.SaveUser(App.user);

            //TODO: send user to server after creation. 

            Navigation.InsertPageBefore(new HomepageNav(user), this);
            Navigation.PopAsync();

            //TODO: save authenticated accounts to Keystore/Keychain
            //// On iOS:
            //AccountStore.Create().Save(eventArgs.Account, "Facebook");

            //// On Android:
            //AccountStore.Create(this).Save(eventArgs.Account, "Facebook");
        }
    }
}
