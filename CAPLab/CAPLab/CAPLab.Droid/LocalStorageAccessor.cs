using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using CAPLab;
using CAPLab.Droid;

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
    class LocalStorageAccessor : ILocalStorageAccessor
    {
        public void SaveUser(User user)
        {
            //string placeHolderUsername = Constants.testUsername;
            //string placeHolderSurveyCondition = Constants.testSurveyCondition;

            var pathToCurrentDirectory = Environment.CurrentDirectory+"\\userProfile.txt";
            var userProfile = new StringBuilder();

            userProfile.AppendLine(user.firstName);
            userProfile.AppendLine(user.lastName);
            userProfile.AppendLine(user.currentWeight.ToString());
            userProfile.AppendLine(user.goalWeight.ToString());
            userProfile.AppendLine(user.deviceType);
            userProfile.AppendLine(user.osuUsername);
            userProfile.AppendLine(user.surveyCondition);

            var fs = new FileStream(pathToCurrentDirectory, FileMode.OpenOrCreate);
            var sw = new StreamWriter(fs);
            sw.Write(userProfile);
            sw.Flush();
            sw.Close();
        }

        public User LoadUser()
        {
            User user = new User();
            var pathToCurrentDirectory = Environment.CurrentDirectory + "\\userProfile.txt";
            var fs = new FileStream(pathToCurrentDirectory, FileMode.Open);
            var sr = new StreamReader(fs);

            user.firstName = sr.ReadLine();
            user.lastName = sr.ReadLine();
            user.currentWeight = Int32.Parse(sr.ReadLine());
            user.goalWeight = Int32.Parse(sr.ReadLine());
            user.deviceType = sr.ReadLine();
            user.osuUsername = sr.ReadLine();
            user.surveyCondition = sr.ReadLine();

            return user;
        }

        public void SaveStats(Stats stats)
        {
            //TODO: Configure app to append all stats of the stats class to a String and write to local storage.
            var pathToCurrentDirectory = Environment.CurrentDirectory + "\\userStats.txt";
            var userStats = new StringBuilder();

            userStats.AppendLine(stats.Steps+string.Empty);

            var fs = new FileStream(pathToCurrentDirectory, FileMode.OpenOrCreate);
            var sw = new StreamWriter(fs);
            sw.Write(userStats);
            sw.Flush();
            sw.Close();
        }

        public Stats LoadStats()
        {
            //TODO: Configure app to search local directory for the stats class, parse it and assign values to a stats class.
            Stats stats = new Stats();
            var pathToCurrentDirectory = Environment.CurrentDirectory + "\\userStats.txt";
            var fs = new FileStream(pathToCurrentDirectory, FileMode.Open);
            var sr = new StreamReader(fs);
            stats.Steps = Int32.Parse(sr.ReadLine());

            return stats;
        }
    }
}
