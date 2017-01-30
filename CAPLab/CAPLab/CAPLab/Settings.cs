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
        public Settings()
        {
            Title = "Settings";

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
                    }
                },
                Intent = TableIntent.Settings
            };

            ToolbarItems.Add(new ToolbarItem("Logout", "logout", () =>
            {
                App.loggedIn = false;
                Navigation.PushAsync(new InitialLoginPage());
            }));
        }
    }
}
