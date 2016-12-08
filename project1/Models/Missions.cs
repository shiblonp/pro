using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Models
{
    [Table("Missions")]
    public class Missions
    {
        [HiddenInput(DisplayValue = false)]
        public int missionID { get; set; }
        [Required(ErrorMessage = "Please enter a description!")]
        public string missionName { get; set; }
        [Required(ErrorMessage = "Please enter a type!")]
        public string missionPresidentsName { get; set; }
        [Required(ErrorMessage = "Please enter a price!")]
        public string missionAddress { get; set; }
        [Required(ErrorMessage = "Please enter a client ID!")]
        public string missionLanguage { get; set; }
        [Required(ErrorMessage = "Please enter a client ID!")]
        public string climate { get; set; }
        [Required(ErrorMessage = "Please enter a client ID!")]
        public string dominantReligion { get; set; }
        [Required(ErrorMessage = "Please enter a client ID!")]
        public string missionFlag { get; set; }
    }
}