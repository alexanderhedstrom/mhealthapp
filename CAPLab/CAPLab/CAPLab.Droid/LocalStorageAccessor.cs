using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using CAPLab;

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
* @version 02/27/2017
* 
*/

namespace CAPLab
{
    class LocalStorageAccessor : ILocalStorageAccessor
    {
        public void SaveUser(User user)
        {
            string placeHolderUsername = Constants.ParticipantID;
            string placeHolderPassword = Constants.Password;
            //TODO: Configure app to append all attributes of the user class to a String and write to local storage.

            var pathToCurrentDirectory = Environment.CurrentDirectory+"\\userProfile.txt";
            var userProfile = new StringBuilder();

            userProfile.AppendLine(user.ParticipantID);
            userProfile.AppendLine(user.Password);


            var fs = new FileStream(pathToCurrentDirectory, FileMode.OpenOrCreate);
            var sw = new StreamWriter(fs);
            sw.Write(userProfile);
            sw.Flush();
            sw.Close();
        }

        public User LoadUser()
        {
            //TODO: Configure app to search local directory for the user class, parse it and assign values to a user clas.
            User user = new User();
            var pathToCurrentDirectory = Environment.CurrentDirectory + "\\userProfile.txt";
            var fs = new FileStream(pathToCurrentDirectory, FileMode.Open);
            var sr = new StreamReader(fs);
            user.ParticipantID = sr.ReadLine();
            user.Password = sr.ReadLine();

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
