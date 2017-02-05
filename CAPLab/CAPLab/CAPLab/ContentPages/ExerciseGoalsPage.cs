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
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Exercise goals here" }
                }
            };
        }
    }
}
