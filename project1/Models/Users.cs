using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Models
{
     [Table("Users")]
    public class Users
    {
       
        public int userID { get; set; }
        [Required(ErrorMessage = "Please enter your email!")]
        public string userEmail { get; set; }
        [Required(ErrorMessage = "Please enter your password!")]
        public string userPassword { get; set; }
        [Required(ErrorMessage = "Please enter your first name!")]
        public string userFirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name!")]
        public string userLastName { get; set; }
    }
}