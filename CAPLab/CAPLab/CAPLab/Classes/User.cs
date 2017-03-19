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
* @version 03/18/2017
* 
*/

namespace CAPLab
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int currentWeight { get; set; }
        public int goalWeight { get; set; }
        public string deviceType { get; set; }
        public string osuUsername { get; set; }
        public string surveyCondition { get; set; }
        //need to set more properties for user

        //public bool firstTimeLogin = true;

        public int steps { get; set; }
        // TODO: implement goals settings on user class. 
        //public string exerciseGoals { get; set;}
        //public string dietGoals { get; set;}


        //TODO set string variables except survey conditon to .ToUpper() when sent to server

        //public User(string firstName, string lastName, string osuUsername, string surveyCondition)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.osuUsername = osuUsername; // TODO: call out to server to check if this value already exists
        //    this.surveyCondition = surveyCondition; // format: "2017-0001-0001-0001" = year-roundofstudy-condition-person

        //}

    }
}
