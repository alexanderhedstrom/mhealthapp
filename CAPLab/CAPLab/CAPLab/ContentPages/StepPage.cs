using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Syncfusion.SfChart.XForms;
using System.Collections.ObjectModel;

namespace CAPLab
{
    public partial class StepPage : ContentPage
    {

        public ObservableCollection<ChartDataPoint> pointCollection { get; set; }

        public StepPage()
        {

            SfChart chart = new SfChart();

            //Initializing Primary Axis
            CategoryAxis primaryAxis = new CategoryAxis();
            primaryAxis.Title.Text = "Day";

            chart.PrimaryAxis = primaryAxis;

            //Initializing Secondary Axis
            NumericalAxis secondaryAxis = new NumericalAxis();
            secondaryAxis.Title.Text = "Number of Steps";

            chart.SecondaryAxis = secondaryAxis;

            this.Content = chart;

            pointCollection = new ObservableCollection<ChartDataPoint>();

            pointCollection.Add(new ChartDataPoint(1, 2586));
            pointCollection.Add(new ChartDataPoint(2, 489));
            pointCollection.Add(new ChartDataPoint(3, 5769));
            pointCollection.Add(new ChartDataPoint(4, 1000));
            pointCollection.Add(new ChartDataPoint(5, 3298));

            //Adding the series to the chart and set the ItemsSource property

            chart.Series.Add(new ColumnSeries()
            {

                ItemsSource = pointCollection

            });
        }


    }
}
