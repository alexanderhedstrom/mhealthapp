using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using CAPLab;
using CAPLab.Droid;
using Android.Widget;
using Plugin.Toasts;
using Android.App;

[assembly: Dependency(typeof(LocalStorageAccessor))]

/*
* File name: LocalStorageAccessor.cs
* 
* @description This class exists to store and retrieve users from local storage. 
*              Info on implementation at the following link: https://developer.xamarin.com/guides/xamarin-forms/working-with/files/#Loading_and_Saving_Files
* 
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 03/18/2017
* 
*/

namespace CAPLab.Droid
{
    class LocalStorageAccessor : Activity, ILocalStorageAccessor
    {
        public void SaveUser(User user)
        {
            //var path = global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;  //Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var fileName = "userProfile.txt";
            var filePath = Path.Combine(path, fileName);
            //Directory.CreateDirectory(path);

            
            var userProfile = new StringBuilder();

            userProfile.AppendLine(user.FirstName);
            userProfile.AppendLine(user.LastName);
            userProfile.AppendLine(user.CurrentWeight.ToString());
            userProfile.AppendLine(user.GoalWeight.ToString());
            userProfile.AppendLine(user.DeviceType);
            userProfile.AppendLine(user.OsuUsername);
            userProfile.AppendLine(user.SurveyCondition);

            System.IO.File.WriteAllText(filePath, userProfile.ToString());

            //var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            //var sw = new StreamWriter(fs);
            //sw.Write(userProfile);
            //sw.Flush();
            //sw.Close();

            
        }

        public User LoadUser()
        {
            User user = new User();
            //var path = global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath; //Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var fileName = "userProfile.txt";
            var filePath = Path.Combine(documentsPath, fileName);
            //Directory.CreateDirectory(path);
            

            //TODO: fix external storage loading issues. Weird cause no issues saving there. 
            try
            {
                if (File.Exists(filePath))
                {
                    //var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    var sr = new StreamReader(filePath);

                    user.FirstName = sr.ReadLine();
                    user.LastName = sr.ReadLine();
                    user.CurrentWeight = Int32.Parse(sr.ReadLine());
                    user.GoalWeight = Int32.Parse(sr.ReadLine());
                    user.DeviceType = sr.ReadLine();
                    user.OsuUsername = sr.ReadLine();
                    user.SurveyCondition = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                //InitialLoginPage.DisplayAlertOnPage("Unable to load user from local storage.");
            }
            
            

            return user;
        }

        public void SaveStats(Stats stats)
        {
            //TODO: Configure app to append all stats of the stats class to a String and write to local storage.
            var path = global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            var fileName = Path.Combine(path, "CAPLab/userStats.txt");
            var userStats = new StringBuilder();

            userStats.AppendLine(stats.Steps+string.Empty);

            var fs = new FileStream(path, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.Write(userStats);
            sw.Flush();
            sw.Close();
        }

        public Stats LoadStats()
        {
            //TODO: Configure app to search local directory for the stats class, parse it and assign values to a stats class.
            Stats stats = new Stats();
            var path = global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            var fileName = Path.Combine(path, "CAPLab/userStats.txt");


            if (File.Exists(fileName))
            {
                var fs = new FileStream(path, FileMode.Open);
                var sr = new StreamReader(fs);
                stats.Steps = Int32.Parse(sr.ReadLine());
            }


            return stats;
        }

        public void Logout()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var fileName = "userProfile.txt";
            var filePath = Path.Combine(path, fileName);
            System.IO.File.Delete(filePath);
        }
    }
}
