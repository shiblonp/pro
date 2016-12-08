using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Models
{
     [Table("MissionQuestions")]
    public class MissionQuestions
    {
       
        public int missionQuestionID { get; set; }
        public int missionID { get; set; }
        public int userID { get; set; }
        [Required(ErrorMessage = "Please enter a question!")]
        public string question { get; set; }
        [Required(ErrorMessage = "Please enter an answer!")]
        public string answer { get; set; }
    }
}