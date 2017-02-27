using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CAPLab
{
    public class InitialSetupPage : ContentPage
    {
        Button dietGoalsButton;
        Button exerciseGoalsButton;
        Button doneButton;

        public InitialSetupPage() // public InitialSetupPage(User user)
        {
            Label userLabel = new Label { Text =  "Your participant ID is: "+Constants.ParticipantID}; //user.ParticipantID
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

        //returns to the previous page
        void doneButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
