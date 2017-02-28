using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
//[assembly: Dependency(typeof(LocalStorageAccessor))]

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
            //Current Issue: the File class isn't recognized by the compiler currently. 
        }

        public User LoadUser()
        {
            User user = new User();

            //TODO: Configure app to search local directory for the user class, parse it and assign values to a User class.

            return user;
        }

        public void SaveStats()
        {
            //TODO: Configure app to append all stats of the user class to a String and write to local storage.
        }

        public string LoadStats()
        {
            string str = "";

            //TODO: Configure app to search local directory for the user class, parse it and assign values to a User class.

            return str;
        }
    }
}
