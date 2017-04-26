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
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("current_weight")]
        public int CurrentWeight { get; set; }

        [JsonProperty("goal_weight")]
        public int GoalWeight { get; set; }


        public string DeviceType { get; set; }

        [JsonProperty("osu_username")]
        public string OsuUsername { get; set; }

        // format: "2017-0001-0001-0001" = year-roundofstudy-condition-person
        [JsonProperty("survey_condition")]
        public string SurveyCondition { get; set; }

        //Set the variable below to 'true' wherever the user is returned from the API once the API has been setup correctly
        public bool RetrievedFromServer { get; set; }


        public int Steps { get; set; } 
        public string ExerciseGoal { get; set;}
        public int DietGoalCommittment { get; set;}



    }
}
