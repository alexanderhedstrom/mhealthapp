using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

/*
* File name: DietGoalsPage.cs
* 
* @description This class exists to render and control the logic of the DietGoalsPage. 
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 02/27/2017
* 
*/

namespace CAPLab
{
    public class DietGoalsPage : ContentPage
    {
        Button doneButton;
        Slider committmentLevel;
        EntryCell currentWeight;
        EntryCell goalWeight;
        EntryCell weeklyWeightLoss;

        public DietGoalsPage()
        {
            Title = "Diet Goals Setup Page";
            currentWeight = new EntryCell { Label = "Current Weight:",
                                            Keyboard = Keyboard.Numeric,
                                            HorizontalTextAlignment = TextAlignment.Center};
            goalWeight = new EntryCell { Label = "Goal Weight:",
                                         Keyboard = Keyboard.Numeric,
                                         HorizontalTextAlignment = TextAlignment.Center};
            weeklyWeightLoss = new EntryCell { Label = "Weekly weight loss:",
                                               Keyboard = Keyboard.Numeric,
                                               HorizontalTextAlignment = TextAlignment.Center};

            currentWeight.PropertyChanged += OnEntryTextChanged;
            goalWeight.PropertyChanged += OnEntryTextChanged;
            weeklyWeightLoss.PropertyChanged += OnEntryTextChanged;

            doneButton = new Button
            {
                Text = "Done?",
                BackgroundColor = Color.Red
            };


            var committmentLabel = new Label { Text = "How commited are you to this goal?"};
            committmentLevel = new Slider(0,10,5);

            var table = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection ()
                    {
                        currentWeight,
                        goalWeight,
                        weeklyWeightLoss
                    }
                }

            };

            doneButton.Clicked += DoneButtonClicked; 

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Enter your diet goals below:" },
                    table,
                    committmentLabel,
                    committmentLevel,
                    doneButton
                }
            };
        }

        //returns to the previous page
        void DoneButtonClicked(object sender, EventArgs e)
        {
            App.user.CurrentWeight = int.Parse(currentWeight.Text);
            App.user.GoalWeight = int.Parse(goalWeight.Text);
            App.user.DietGoalCommittment = (int)committmentLevel.Value;
            Navigation.PopAsync();
        }
        //validates input in the weight fields. Limits user to 3 characters and a total less than 600lbs
        private void OnEntryTextChanged(object sender, EventArgs e)
        {
            var entry = (EntryCell)sender;
            if (string.IsNullOrEmpty(entry.Text))
                return;
            if (entry.Text.Length > 3)
            {
                string entryText = entry.Text;
                entry.Text = entryText;
            }
            if (int.Parse(entry.Text) > 600 )
            {
                entry.Text = "";
            }
        }
    }
}
