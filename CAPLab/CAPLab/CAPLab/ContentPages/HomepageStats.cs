﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

/*
* File name: HomepageStats.cs
* 
* @description This class exists to render and control the logic of the HomepageStats page. 
*              This page is to contain the primary agregate stats generated by the app.
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 02/27/2017
* 
*/


namespace CAPLab
{
    class HomepageStats : ContentPage
    {
        public HomepageStats()
        {
            Icon = "homeIcon.png";
            var placeholderText = new Label
            {
                Text = "This page is to contain the primary agregate stats generated by the app."
            };

            //placeholder boxes
            Button stepButton = new Button { Text = "Your steps here:" };
      
            Label box2Label = new Label { Text = "Your Exercise goal progress here:" };
            BoxView box2 = new BoxView
            {
                Color = Color.Gray
            };
            Label box3Label = new Label { Text = "Your Diet goal progress here:" };
            BoxView box3 = new BoxView
            {
                Color = Color.Gray
            };
            Button weightButton = new Button { Text = "Your weight progress here: " };
            Button locationButton = new Button { Text = "Your location here: " };
            weightButton.Clicked += weightButton_Clicked;
            stepButton.Clicked += stepButton_Clicked;
            locationButton.Clicked += locationButton_Clicked;
            Content = new StackLayout
            {
                Children =
                {
                    placeholderText,
                    stepButton,
                    box2Label,
                    box2,
                    box3Label,
                    box3,
                    weightButton,
                    locationButton
                }
            };
        }
        void weightButton_Clicked (Object sender, EventArgs e) 
        {
            Navigation.PushAsync(new WeightPage());
        }

        void stepButton_Clicked (Object sender, EventArgs e)
        {
            Navigation.PushAsync(new StepPage());
        }
        void locationButton_Clicked(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new GPSPage());
        }
    }
}
