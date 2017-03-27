using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

/*
* File name: InitialSetupPage.cs
* 
* @description This class exists to render and control the logic of the initial login page of the primary app. 
*              This page is to contain the first time setup and logic for generation of a User class. 
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 03/18/2017
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
            Label userLabel = new Label { Text =  "Hi "+user.firstName+", Your OSU ID is: "+user.osuUsername};
            Label instructionText1 = new Label { Text = "Connect your accounts by selecting each one below: "};
            Label instructionText2 = new Label { Text = "Set your goals!" };
            var fitBitButton = new Button
            {
                Text = "FitBit",
                BackgroundColor = Color.Gray
            };

            var myFitnessPalButton = new Button
            {
                Text = "MyFitnessPal",
                BackgroundColor = Color.Gray
            };

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
            exerciseGoalsButton = new Button
            {
                Text = "Exercise Goals",
                BackgroundColor = Color.Gray
            };
            doneButton = new Button
            {
                Text = "Done?",
                BackgroundColor = Color.Red
            };

            dietGoalsButton.Clicked += dietGoalsButtonClicked;
            exerciseGoalsButton.Clicked += exerciseGoalsButtonClicked;
            doneButton.Clicked += doneButtonClicked;

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

        //TODO: use App.user to attach values created by child pages to the primary user. 

        // launches diet goals page
        void dietGoalsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DietGoalsPage());
        }
        //launches exercise goals page
        void exerciseGoalsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExerciseGoalsPage());
        }

        //Launches the homepage, passes the user object and removes the current page from view
        void doneButtonClicked(object sender, EventArgs e)
        {
            var localStorage = DependencyService.Get<ILocalStorageAccessor>();
            localStorage.SaveUser(user);

            //TODO: send user to server after creation. 

            Navigation.InsertPageBefore(new HomepageNav(user), this);
            Navigation.PopAsync();
        }
    }
}
