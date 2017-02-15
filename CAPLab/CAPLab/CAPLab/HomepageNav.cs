using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//This class is the primary navigation/home page to other areas of the app

//Notes on implementation found at link below:
//https://developer.xamarin.com/api/type/Xamarin.Forms.TabbedPage/

namespace CAPLab
{
    class HomepageNav : TabbedPage
    {
        public HomepageNav()
        {

            //Moves settings page to a button on the toolbar. 
            // the second argument should be the name of an icon image file (PNG)
            ToolbarItems.Add( new ToolbarItem ("Settings", "settings", () =>
                {
                    Navigation.PushAsync(new Settings());
                }));

            Title = "OSU CAPLab";
            

            Children.Add(new HomepageStats());

            Children.Add(new EatingStats());

            Children.Add(new ExerciseStats());

            Children.Add(new SurveyPage());
        }


    }
}
