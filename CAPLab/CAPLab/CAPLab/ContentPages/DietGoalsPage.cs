using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CAPLab
{
    public class DietGoalsPage : ContentPage
    {
        public DietGoalsPage()
        {

            var currentWeight = new EntryCell { Label = "Current Weight:" };
            var goalWeight = new EntryCell { Label = "Goal Weight:" };
            var weeklyWeightLoss = new EntryCell { Label = "Weekly weight loss:" };


            var doneButton = new Button
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

            Content = new StackLayout
            {
                Children = {
                    table,
                    committmentLabel,
                    committmentLevel,
                    doneButton
                }
            };
        }
    }
}
