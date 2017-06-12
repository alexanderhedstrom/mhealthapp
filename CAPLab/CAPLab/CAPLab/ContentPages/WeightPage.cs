using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Syncfusion.SfGauge.XForms;
using System.Collections.ObjectModel;

namespace CAPLab
{
    public partial class WeightPage : ContentPage
    {

        Entry startingWeight, currentWeight, desiredWeight;
        Scale scale = new Scale();
        RangePointer currentWeightPointer = new RangePointer();
        RangePointer desiredWeightPointer = new RangePointer();
        Header startingWeightHeader = new Header();
        Header currentWeightHeader = new Header();
        Header desiredWeightHeader = new Header();

        public WeightPage()
        {

            startingWeight = new Entry
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Placeholder = "Enter your starting weight here",
            };
            startingWeight.Keyboard = Keyboard.Numeric;
            startingWeight.Completed += StartingWeight_Completed;

            currentWeight = new Entry
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Placeholder = "Enter your current weight here",
            };
            currentWeight.Keyboard = Keyboard.Numeric;
            currentWeight.Completed += CurrentWeight_Completed;

            desiredWeight = new Entry
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Placeholder = "Enter your desired weight here",
            };

            desiredWeight.Keyboard = Keyboard.Numeric;
            desiredWeight.Completed += DesiredWeight_Completed;

            SfCircularGauge circularGauge = new SfCircularGauge();
            ObservableCollection<Scale> scales = new ObservableCollection<Scale>();

            //Scales
            scale.StartValue = 0;
            scale.EndValue = 100;
            scale.StartAngle = -90;
            scale.SweepAngle = 360;
            scale.RimThickness = 30;
            scale.RimColor = Color.FromHex("#606060");
            scale.ShowLabels = false;
            scale.MinorTicksPerInterval = 0;
            scale.Interval = 1;
            scale.ShowRim = true;
            scale.ShowTicks = false;
            scale.RadiusFactor = 0.4;

            List<Pointer> pointers = new List<Pointer>();
            currentWeightPointer.Value = 0;
            currentWeightPointer.Color = Color.FromHex("#B2E812");
            currentWeightPointer.Thickness = 30;

            desiredWeightPointer.Value = 0;
            desiredWeightPointer.Color = Color.FromHex("#CC0000");
            desiredWeightPointer.Thickness = 30;

            pointers.Add(currentWeightPointer);
            pointers.Add(desiredWeightPointer);

            scale.Pointers = pointers;
            scales.Add(scale);
            circularGauge.Scales = scales;

            startingWeightHeader.Text = "Your starting weight: ";
            startingWeightHeader.TextSize = 12;
            startingWeightHeader.Position = Device.OnPlatform(iOS: new Point(.5, .6), Android: new Point(0.55, 0.15), WinPhone: new Point(0.32, 0.7));
            startingWeightHeader.ForegroundColor = Color.Gray;

            //var diff = Convert.ToDouble(StartingWeight.Text) - Convert.ToDouble(currentWeight.Text);
            //value.Text = "You've lost lbs!"; Pointer Value can be mapped directly to header Text as follows—[ value.Text= (rangePointer.Value).ToString();]

            currentWeightHeader.TextSize = 20;
            currentWeightHeader.Position = Device.OnPlatform(iOS: new Point(.5, .6), Android: new Point(0.5, 0.45), WinPhone: new Point(0.32, 0.7));
            currentWeightHeader.ForegroundColor = Color.Gray;

            desiredWeightHeader.TextSize = 12;
            desiredWeightHeader.Position = Device.OnPlatform(iOS: new Point(.5, .6), Android: new Point(1.0, 0.5), WinPhone: new Point(0.32, 0.7));
            desiredWeightHeader.ForegroundColor = Color.Gray;

            circularGauge.Headers.Add(desiredWeightHeader);
            circularGauge.Headers.Add(currentWeightHeader);
            circularGauge.Headers.Add(startingWeightHeader);


            Content = new StackLayout
            {
                Children =
                {
                    startingWeight,
                    desiredWeight,
                    currentWeight,
                    circularGauge
                }
            };
        }

        private void StartingWeight_Completed(object sender, EventArgs e)
        {
            startingWeightHeader.Text = "Beginning weight \n" + startingWeight.Text + " lbs.";
            scale.EndValue = Convert.ToDouble(startingWeight.Text);
        }

        private void CurrentWeight_Completed(object sender, EventArgs e)
        {
            currentWeightPointer.Value = Convert.ToDouble(startingWeight.Text);
            currentWeightPointer.RangeStart = 45;
            var diff = Convert.ToDouble(startingWeight.Text) - Convert.ToDouble(currentWeight.Text);
            currentWeightHeader.Text = "You've lost \n" + diff + " lbs!";
        }

        private void DesiredWeight_Completed(object sender, EventArgs e)
        {
            desiredWeightPointer.Value = Convert.ToDouble(desiredWeight.Text);
            desiredWeightPointer.RangeStart = 45;
            desiredWeightHeader.Text = "Goal weight \n" + desiredWeight.Text + " lbs.";
        }
    }

}
