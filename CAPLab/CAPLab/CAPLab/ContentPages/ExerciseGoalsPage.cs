using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

/*
* File name: ExerciseGoalsPage.cs
* 
* @description This class exists to render and control the logic of the exercise goals page of the primary app. 
*              This page is to contain the exercise goals selection options. 
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 02/27/2017
* 
*/

namespace CAPLab
{
    public class ExerciseGoalsPage : ContentPage
    {
        Button doneButton;

        public ExerciseGoalsPage()
        {
            Label box2Label = new Label { Text = "Your Exercise goal progress here:" };

            doneButton = new Button {Text = "Done?", BackgroundColor = Color.Red };
            doneButton.Clicked += doneButtonClicked;

            //Declaring exercise goals variables below
            var choice1 = new SwitchCell { Text = "Lose weight" };
            var choice2 = new SwitchCell { Text = "Gain Muscle definition" };
            var choice3 = new SwitchCell { Text = "Become stronger" };
            var choice4 = new SwitchCell { Text = "Become healthier" };
            var choice5 = new SwitchCell { Text = "Train for an event/sport" };
            var choice6 = new SwitchCell { Text = "Other" };

            //Declaring table to hold goals variables below
            var goalsTable = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection (" ")
                    {
                        choice1,
                        choice2,
                        choice3,
                        choice4,
                        choice5,
                        choice6
                    }
                }
            };

            Title = "Exercise goals setup page";

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Check all that apply" },
                    goalsTable,
                    doneButton
                }
            };
        }

        //returns to the previous page
        void doneButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
