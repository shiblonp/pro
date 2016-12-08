using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project1.Models
{
    public class UserMissionQuestions
    {
        public int userID { get; set; }
        public string userEmail { get; set; }        
        public string userPassword { get; set; }      
        public string userFirstName { get; set; }       
        public string userLastName { get; set; }
        public int missionQuestionID { get; set; }
        public int missionID { get; set; }      
        public string question { get; set; }      
        public string answer { get; set; }      
        public string missionName { get; set; }      
        public string missionPresidentsName { get; set; }      
        public string missionAddress { get; set; }    
        public string missionLanguage { get; set; }       
        public string climate { get; set; }       
        public string dominantReligion { get; set; }     
        public string missionFlag { get; set; }
    }
}