using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

/*
* File name: Settings.cs
* 
* @description This class exists to store and display the settings of the primary app. 
*              This page is to contain the various settings in the app that the user can configure. 
*              Notes on implementation at the link: https://developer.xamarin.com/guides/xamarin-forms/user-interface/tableview/
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 03/18/2017
* 
*/

//
//

namespace CAPLab
{
    class Settings : ContentPage
    {
        TextCell initialSetupLink;
        TextCell dietGoalsLink;
        TextCell exerciseGoalsLink;
        TextCell licenseLink;

        User user;

        public Settings(User user)
        {
            Title = "Settings";
            Icon = "settings.png";
            this.user = user;
            //declaring TextCell links to other pages
            initialSetupLink = new TextCell { Text = "Initial setup base page", Detail = "Launches the first-time setup page", TextColor = Color.Black};
            dietGoalsLink = new TextCell { Text = "Diet goals page", Detail = "Launches the diet goals setup page", TextColor = Color.Black };
            exerciseGoalsLink = new TextCell { Text = "Exercise goals page", Detail = "Launches the exercise goals etup page", TextColor = Color.Black };
            licenseLink = new TextCell { Text = "Our license", TextColor = Color.Black };

            //declaring table sections

            //declaring the primary content of the page
            Content = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection (" ")
                    {
                        new SwitchCell {Text = "Test 1" },
                        new SwitchCell {Text = "Test 2" },
                        new EntryCell {Label = "Test 3", Text = "1234" }
                    },
                    new TableSection (" ")
                    {
                        new SwitchCell {Text = "Test 1" },
                        new SwitchCell {Text = "Test 2" },
                        new EntryCell {Label = "Test 3", Text = "1234" }
                    },
                    new TableSection (" ")
                    {
                        //initialSetupLink,
                        dietGoalsLink,
                        exerciseGoalsLink
                    },
                    new TableSection (" ")
                    {
                        licenseLink
                    }
                },
                Intent = TableIntent.Settings
            };

            initialSetupLink.Tapped += initialSetupLinkClicked;
            dietGoalsLink.Tapped += dietGoalsLinkClicked;
            exerciseGoalsLink.Tapped += exerciseGoalsLinkClicked;
            licenseLink.Tapped += licenseLinkClicked;

            ToolbarItems.Add(new ToolbarItem("Logout", "logoutIcon.png", () =>
            {
                App.loggedIn = false;
                Icon = "logoutIcon.png";
                Navigation.PushAsync(new InitialLoginPage());
            }));
        }

        //TODO pass the App.user class to the classes below and have them render based on the user data

        //launches initial setup page
        void initialSetupLinkClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InitialSetupPage(user)); 
        }
        // launches diet goals page
        void dietGoalsLinkClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DietGoalsPage());
        }
        //launches exercise goals page
        void exerciseGoalsLinkClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExerciseGoalsPage());
        }

        //launches the license page
        void licenseLinkClicked (object sender, EventArgs e)
        {
            Navigation.PushAsync(new LicensePage());
        }
    }
}
