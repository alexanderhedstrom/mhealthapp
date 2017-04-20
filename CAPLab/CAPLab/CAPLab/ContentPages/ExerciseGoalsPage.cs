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
        SwitchCell choice1;
        SwitchCell choice2;
        SwitchCell choice3;
        SwitchCell choice4;
        SwitchCell choice5;
        SwitchCell choice6;

        public ExerciseGoalsPage()
        {
            Label box2Label = new Label { Text = "Your Exercise goal progress here:" };

            doneButton = new Button {Text = "Done?", BackgroundColor = Color.Red };
            doneButton.Clicked += DoneButtonClicked;

            //Declaring exercise goals variables below
            choice1 = new SwitchCell { Text = "Lose weight" };
            choice2 = new SwitchCell { Text = "Gain Muscle definition" };
            choice3 = new SwitchCell { Text = "Become stronger" };
            choice4 = new SwitchCell { Text = "Become healthier" };
            choice5 = new SwitchCell { Text = "Train for an event/sport" };
            choice6 = new SwitchCell { Text = "Other" };

            choice1.OnChanged += ChoiceSelected;
            choice2.OnChanged += ChoiceSelected;
            choice3.OnChanged += ChoiceSelected;
            choice4.OnChanged += ChoiceSelected;
            choice5.OnChanged += ChoiceSelected;
            choice6.OnChanged += ChoiceSelected;

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

        void ChoiceSelected(object sender, EventArgs e)
        {
            if ((SwitchCell)sender == choice1)
            {
                App.user.ExerciseGoal = choice1.Text;
                //choice1.On = true;
                choice2.On = false;
                choice3.On = false;
                choice4.On = false;
                choice5.On = false;
                choice6.On = false;
            }else if((SwitchCell)sender == choice2)
            {
                App.user.ExerciseGoal = choice2.Text;
                choice1.On = false;
                //choice2.On = true;
                choice3.On = false;
                choice4.On = false;
                choice5.On = false;
                choice6.On = false;
            }
            else if ((SwitchCell)sender == choice3)
            {
                App.user.ExerciseGoal = choice3.Text;
                choice1.On = false;
                choice2.On = false;
                //choice3.On = true;
                choice4.On = false;
                choice5.On = false;
                choice6.On = false;
            }
            else if ((SwitchCell)sender == choice4)
            {
                App.user.ExerciseGoal = choice4.Text;
                choice1.On = false;
                choice2.On = false;
                choice3.On = false;
                //choice4.On = true;
                choice5.On = false;
                choice6.On = false;
            }
            else if ((SwitchCell)sender == choice5)
            {
                App.user.ExerciseGoal = choice5.Text;
                choice1.On = false;
                choice2.On = false;
                choice3.On = false;
                choice4.On = false;
                //choice5.On = true;
                choice6.On = false;
            }
            else if ((SwitchCell)sender == choice6)
            {
                App.user.ExerciseGoal = choice6.Text;
                choice1.On = false;
                choice2.On = false;
                choice3.On = false;
                choice4.On = false;
                choice5.On = false;
                //choice6.On = true;
            }
        }

        //returns to the previous page
        void DoneButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
