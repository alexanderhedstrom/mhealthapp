using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//This page is to contain the various settings in the app that the user can configure. 

//Notes on implementation at the link below. 
//https://developer.xamarin.com/guides/xamarin-forms/user-interface/tableview/

namespace CAPLab
{
    class Settings : ContentPage
    {
        TextCell initialSetupLink;
        TextCell dietGoalsLink;
        TextCell exerciseGoalsLink;

        public Settings()
        {
            Title = "Settings";
            //declaring TextCell links to other pages
            initialSetupLink = new TextCell { Text = "Initial setup base page", Detail = "Launches the first-time setup page", };
            dietGoalsLink = new TextCell { Text = "Diet goals page", Detail = "Launches the diet goals setup page" };
            exerciseGoalsLink = new TextCell { Text = "Exercise goals page", Detail = "Launches the exercise goals etup page" };

            //declaring the primary content of the page
            Content = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection ("Test section 1")
                    {
                        new SwitchCell {Text = "Test 1" },
                        new SwitchCell {Text = "Test 2" },
                        new EntryCell {Label = "Test 3", Text = "1234" }
                    },
                    new TableSection ("Test section 2")
                    {
                        new SwitchCell {Text = "Test 1" },
                        new SwitchCell {Text = "Test 2" },
                        new EntryCell {Label = "Test 3", Text = "1234" }
                    },
                    new TableSection ("Initial setup pages")
                    {
                        initialSetupLink,
                        dietGoalsLink,
                        exerciseGoalsLink
                    },
                    new TableSection ("Licensing")
                    {
                        new TextCell {Text = "Our license" }
                    }
                },
                Intent = TableIntent.Settings
            };

            initialSetupLink.Tapped += initialSetupLinkClicked;
            dietGoalsLink.Tapped += dietGoalsLinkClicked;
            exerciseGoalsLink.Tapped += exerciseGoalsLinkClicked;

            ToolbarItems.Add(new ToolbarItem("Logout", "logout", () =>
            {
                App.loggedIn = false;
                Navigation.PushAsync(new InitialLoginPage());
            }));
        }

        //launches initial setup page
        void initialSetupLinkClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InitialSetupPage());
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
    }
}
