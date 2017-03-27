using Newtonsoft.Json;
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
        [JsonProperty("first_name")]
        public string firstName { get; set; }

        [JsonProperty("last_name")]
        public string lastName { get; set; }

        [JsonProperty("current_weight")]
        public int currentWeight { get; set; }

        [JsonProperty("goal_weight")]
        public int goalWeight { get; set; }


        public string deviceType { get; set; }

        [JsonProperty("osuUsername")]
        public string osuUsername { get; set; }

        [JsonProperty("survey_condition")]
        public string surveyCondition { get; set; }

        public bool retrievedFromServer { get; set; }


        public int steps { get; set; }
        // TODO: implement goals settings on user class. 
        //public string exerciseGoals { get; set;}
        //public string dietGoals { get; set;}

        //public User(string firstName, string lastName, string osuUsername, string surveyCondition)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.osuUsername = osuUsername; // TODO: call out to server to check if this value already exists
        //    this.surveyCondition = surveyCondition; // format: "2017-0001-0001-0001" = year-roundofstudy-condition-person

        //}

    }
}
