using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using project1.Models;

namespace project1.DAL
{
    //mission class created that inherits from dbContext
    public class Mission : DbContext
    {
        //constructor to acccess dbContext
        public Mission(): base("Mission")
        {

        }
        //db sets created to hold information from the database
        public DbSet<MissionQuestions> missionQuestion { get; set; }
        public DbSet<Missions> mission { get; set; }
        public DbSet<Users> user { get; set; }
        public DbSet<UserMissionQuestions> usermissionquestion { get; set; }
    }
}