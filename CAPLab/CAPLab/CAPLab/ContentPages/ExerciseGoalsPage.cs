using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CAPLab
{
    public class ExerciseGoalsPage : ContentPage
    {
        public ExerciseGoalsPage()
        {
            Label box2Label = new Label { Text = "Your Exercise goal process here:" };

            List<SwitchCell> choices = new List<SwitchCell>
            {
                new SwitchCell { Text = "Lose weight" },
                new SwitchCell { Text = "Gain Muscle definition" },
                new SwitchCell { Text = "Become stronger" },
                new SwitchCell { Text = "Become healthier" },
                new SwitchCell { Text = "Train for an event/sport" },
                new SwitchCell { Text = "Other" }
            };

            ListView exerciseGoalsList = new ListView
            {
                ItemsSource = choices,
            };

            Title = "Exercise goals setup page";

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Check all that apply" },
                    exerciseGoalsList
                }
            };
        }
    }
}
