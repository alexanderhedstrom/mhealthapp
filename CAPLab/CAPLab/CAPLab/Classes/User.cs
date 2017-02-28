using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* File name: User.cs
* 
* @description This class exists contain the primary attributes of the user. 
*              
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 02/27/2017
* 
*/

namespace CAPLab
{
    public class User
    {
        public string ParticipantID { get; set; }
        public string Password { get; set; }
        //need to set more properties for user

        public bool firstTimeLogin = true;

        public int steps { get; set; }
        //public string exerciseGoals { get; set;}
        //public string dietGoals { get; set;}


        public User()
        {
            ParticipantID = ""; // call out to server for this value
            Password = "";
            steps = 0;

        }
    }
}
