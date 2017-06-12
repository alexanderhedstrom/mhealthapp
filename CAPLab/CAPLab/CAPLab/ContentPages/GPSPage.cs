using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CAPLab
{

    public class GPSPage : ContentPage
    {
        Label lblLat, lblLng;
        ILocation loc;

        public GPSPage()
        {
            lblLat = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Lat",
            };
            lblLng = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Lng",
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Current Location"
                        },
                        lblLat,
                        lblLng
                    }
            };

            // Handle when your app starts
            loc = DependencyService.Get<ILocation>();
            loc.locationObtained += (object sender,
                ILocationEventArgs e) => {
                    var lat = e.lat;
                    var lng = e.lng;
                    lblLat.Text = lat.ToString();
                    lblLng.Text = lng.ToString();
                };
            loc.ObtainMyLocation();

        }




    }
}