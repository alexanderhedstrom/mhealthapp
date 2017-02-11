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
        public InitialSetupPage()
        {
            Label userLabel = new Label { Text =  "Your participant ID is: "+Constants.ParticipantID};
            Label instructionText1 = new Label { Text = "Connect your accounts by selecting each one below: "};
            Label instructionText2 = new Label { Text = "Set your goals!" };
            var fitBitButton = new Button
            {
                Text = "FitBit",
                BackgroundColor = Color.Red
            };

            var myFitnessPalButton = new Button
            {
                Text = "MyFitnessPal",
                BackgroundColor = Color.Red
            };

            var otherAppButton = new Button
            {
                Text = "Other",
                BackgroundColor = Color.Red
            };

            var dietGoalsButton = new Button
            {
                Text = "Diet Goals",
                BackgroundColor = Color.Red
            };
            var exerciseGoalsButton = new Button
            {
                Text = "Exercise Goals",
                BackgroundColor = Color.Red
            };
            var doneButton = new Button
            {
                Text = "Done?",
                BackgroundColor = Color.Red
            };

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
    }
}
