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

        public DietGoalsPage()
        {
            Title = "Diet Goals Setup Page";
            var currentWeight = new EntryCell { Label = "Current Weight:", Keyboard = Keyboard.Numeric };
            var goalWeight = new EntryCell { Label = "Goal Weight:", Keyboard = Keyboard.Numeric };
            var weeklyWeightLoss = new EntryCell { Label = "Weekly weight loss:", Keyboard = Keyboard.Numeric };


            doneButton = new Button
            {
                Text = "Done?",
                BackgroundColor = Color.Red
            };


            var committmentLabel = new Label { Text = "How commited are you to this goal?"};
            var committmentLevel = new Slider(0,10,5);

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

            doneButton.Clicked += doneButtonClicked; 

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
        void doneButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
